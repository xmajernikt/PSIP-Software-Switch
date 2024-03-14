using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    internal class MacTable
    {
        private static Dictionary<string, int> macHashTable = new Dictionary<string, int>();
        private static MainWindow mainWindow;
        private static readonly Object lockObject = new Object();
        private static DataTable macTable;
        private Timer timer;

        public MacTable(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            mainWindow.Load += MainForm_Load;


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
                foreach (DataRow row in macTable.Rows)
                {
                    int time = Convert.ToInt32(row["TIME"]);
                    if (time > 0)
                    {
                        row["TIME"] = time - 1;
                    }
                    else
                    {
                        // Delete the row if time is zero
                        macHashTable.Remove(Convert.ToString(row["MAC"]));
                        macTable.Rows.Remove(row);
                        break; // Exit the loop after removing the row
                    }
                }
            }
            
        } 

        private void setUpMacTable()
        {
            macTable = new DataTable();
            macTable.Columns.Add("MAC",  typeof(string));
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
            if (!macHashTable.ContainsKey(FormatMac(macAddress))) 
            {
                Console.WriteLine("OOOOOOOOOOOOOOOOOOOO");
                DataRow newRow = macTable.NewRow();
                macHashTable.Add(FormatMac(macAddress), portIndex);
                newRow["MAC"] = FormatMac(macAddress);
                newRow["PORT"] = portIndex;
                newRow["TIME"] = 30;
                macTable.Rows.Add(newRow);
                mainWindow.Invoke((MethodInvoker)delegate {
                    mainWindow.macTable.DataSource = macTable; // Update the data source after adding the row
                    mainWindow.macTable.Refresh(); // Refresh the DataGridView to reflect the changes
                });
            }

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

    }

}
