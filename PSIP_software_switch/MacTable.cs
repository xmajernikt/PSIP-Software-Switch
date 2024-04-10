using PacketDotNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    public class MacTable
    {
        public static Dictionary<string, int> macHashTable = new Dictionary<string, int>();
        private static Dictionary<string, int> macToTime = new Dictionary<string, int>();
        private static MainWindow mainWindow;
        public static readonly Object lockObject = new Object();
        private static DataTable macTable;
        private Timer timer;
        private static int macRecordTimer;
        private static int oldMacRecordTimer;

        public MacTable(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            mainWindow.Load += MainForm_Load;
            macRecordTimer = 30;
            oldMacRecordTimer = macRecordTimer;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Call fillRowsColumns method when the form loads
            setUpMacTable();
            startTimer();
        }

        private void startTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (macTable.Rows != null)
            {
                try
                {
                    List<DataRow> rowsToDelete = new List<DataRow>();
                    List<string> macsToDelete = new List<string>();
                    foreach (DataRow row in macTable.Rows)
                    {
                        int time = Convert.ToInt32(row["TIME"]);
                        if (time > 0)
                        {
                            if (row["TIME"] != null)
                            {
                                row["TIME"] = time - 1;

                            }
                        }
                        else if (time == 0)
                        {
                            // Delete the row if time is zero
                            Syslog.EnqueuePacket($"A record with MAC address {row["MAC"]} has been deleted.", Syslog.SyslogSeverity.Warning);
                            rowsToDelete.Add(row);
                            macsToDelete.Add((string)row["MAC"]);

                            //break; // Exit the loop after removing the row
                        }

                        if (ShouldDeleteRecord((string)row["MAC"]))
                        {
                            rowsToDelete.Add(row);
                            macsToDelete.Add((string)row["MAC"]);

                        }
                    }

                    //foreach (string mac in macsToDelete)
                    //{
                    //    macHashTable.Remove(mac);
                    //    macToTime.Remove(mac);
                    //}
                    foreach (DataRow row in rowsToDelete)
                    {
                        
                        macHashTable.Remove(Convert.ToString(row["MAC"]));
                        macToTime.Remove(Convert.ToString(row["MAC"]));
                        macTable.Rows.Remove(row);

                    }

                    //rowsToDelete.Clear();
                    macsToDelete.Clear();
                    mainWindow.macTable.Refresh();
                    //mainWindow.Invoke((MethodInvoker)delegate
                    //{
                    //    //mainWindow.macTable.DataSource = macTable;
                    //    mainWindow.macTable.Refresh(); // Refresh the DataGridView to reflect the changes
                    //});
                }
                catch { }



            }

        }

        private void setUpMacTable()
        {
            macTable = new DataTable();
            macTable.Columns.Add("MAC", typeof(string));
            macTable.Columns.Add("PORT", typeof(int));
            macTable.Columns.Add("TIME", typeof(int));


            mainWindow.macTable.DataSource = macTable;

            mainWindow.macTable.Columns["MAC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mainWindow.macTable.Columns["PORT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mainWindow.macTable.Columns["TIME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            mainWindow.macTable.Columns["MAC"].Width = 125;
            mainWindow.macTable.Columns["PORT"].Width = 50;
            mainWindow.macTable.Columns["TIME"].Width = 50;

        }

        public static void addRow(string macAddress, int portIndex)
        {
            if (!inMacTable(macAddress) && !IsForbbiden(macAddress))
            {
                Syslog.EnqueuePacket($"A new record with mac address {FormatMac(macAddress)} has been added", Syslog.SyslogSeverity.Informational);
                DataRow newRow = macTable.NewRow();
                macHashTable.Add(FormatMac(macAddress), portIndex);
                macToTime.Add(FormatMac(macAddress), macRecordTimer);
                newRow["MAC"] = FormatMac(macAddress);
                newRow["PORT"] = portIndex;
                newRow["TIME"] = macRecordTimer;
                macTable.Rows.Add(newRow);
                mainWindow.Invoke((MethodInvoker)delegate
                {
                    mainWindow.macTable.DataSource = macTable; // Update the data source after adding the row
                    mainWindow.macTable.Refresh(); // Refresh the DataGridView to reflect the changes
                });
            }

        }

        public void DeleteAllRecords()
        {
            macHashTable.Clear();
            macTable.Rows.Clear();
            macToTime.Clear();

        }

        public static string FormatMac(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var formattedString = new StringBuilder();
            int count = 0;

            foreach (char c in input)
            {
                formattedString.Append(c);
                count++;

                // Insert '-' after every 2 characters except for the last one
                if (count % 2 == 0 && count != input.Length)
                {
                    formattedString.Append('-');
                }
            }

            return formattedString.ToString();
        }

        public static bool inMacTable(string macAddress)
        {
            if (FormatMac(macAddress).Equals("FF-FF-FF-FF-FF-FF"))
            {
                return false;
            }

            if (!macHashTable.ContainsKey(FormatMac(macAddress)))
            {
                
                return false;
            }
            return true;
        }

        public void updateTime(string srcMacAddress)
        {
            if (macTable.Rows != null)
            {

                foreach (DataRow row in macTable.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (row["MAC"].Equals(FormatMac(srcMacAddress)))
                        {
                            try
                            {
                               
                                macToTime[FormatMac(srcMacAddress)] = macRecordTimer;
                                row["TIME"] = macRecordTimer;
                                break;

                                



                            }
                            catch (Exception e) { }



                        }
                    }
                    
                }

            }
        }

        private bool ShouldDeleteRecord(string srcMacAddress)
        {
            int time = 0;
            foreach (DataRow row in macTable.Rows)
            {   
                if (row["MAC"].Equals(srcMacAddress))
                {
                    time = (int)row["TIME"];
                    if (macToTime[srcMacAddress] - time >= macRecordTimer)
                    {
                        
                        return true;
                    }
                }

            }
            return false;
        }

        public void SetMacRecordTime(int newTime)
        {
            macRecordTimer = newTime;
            oldMacRecordTimer = macRecordTimer;
        }

        public static void CableSwitch(string macAddress, int recvIndex, int sendIndex)
        {

            if (macHashTable.ContainsKey(FormatMac(macAddress)))
            {

                //Sniffer.ClearBuffer();
                //Sniffer.SwitchPortMapping();
                
                foreach (DataRow row in macTable.Rows)
                {
                    if (row["MAC"].Equals(FormatMac(macAddress)))
                    {
                        int swappedPortMac = (int)row["PORT"] == 1 ? 2 : 1;
                        row["PORT"] = swappedPortMac;
                        break;
                    }
                } 
                if (macHashTable.ContainsKey(FormatMac(macAddress)))
                {   
                    
                    int swappedPort = macHashTable[FormatMac(macAddress)] == 1 ? 2 : 1;

                    macHashTable[FormatMac(macAddress)] = swappedPort;

                }



                
            }
        }
    
           
        
        public static void DeleteSpecificRecords(int portNumber)
        {
            List<DataRow> dataRows = new List<DataRow>();
            List<string> macAddresses = new List<string>();
            if (macTable.Rows.Count > 0)
            {
                foreach (DataRow row in macTable.Rows)
                {
                    if ((int)row["PORT"] == portNumber)
                    {
                        dataRows.Add(row);
                        macAddresses.Add((string)row["MAC"]);
                    }
                }

            }

            foreach (DataRow row in dataRows)
            {
                macTable.Rows.Remove(row);
            }

            foreach (string macAddress in macAddresses)
            {
                macHashTable.Remove(macAddress);
                macToTime.Remove(macAddress);
            }
        }

        public static int GetRecordPort(string sourceMacAddress)
        {
            if (macHashTable.ContainsKey (FormatMac(sourceMacAddress)))
            {
                return macHashTable[FormatMac(sourceMacAddress)];
            }
            return 0;
        }

        private static bool IsForbbiden(string macAddress)
        {
            
            if (macAddress.StartsWith("00E0") || macAddress.StartsWith("F8E"))
            {
               
                return true;
            }
            return false;
        }

    }

}
