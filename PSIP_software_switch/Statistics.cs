using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    internal class Statistics
    {
        private static MainWindow mainWindow;
        private static DataTable stats1DataTable;
        private static DataTable stats2DataTable;
        private static object stats1DataTableLock;
        private static object stats2DataTableLock;
        // static MainWindow mainWindow = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
        public Statistics(MainWindow _mainForm)
        {
            mainWindow = _mainForm;
            stats1DataTableLock = new object();
            stats2DataTableLock = new object();

            // Subscribe to the Load event of the main form
            mainWindow.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Call fillRowsColumns method when the form loads
            fillRowsColumns(mainWindow.statistics1);
        }

        public void fillRowsColumns(DataGridView dataGridView)
        {
            stats1DataTable = new DataTable();
            stats2DataTable = new DataTable();

            DataRow[] dataRowsIntf1 = new DataRow[9];
            DataRow[] dataRowsIntf2 = new DataRow[9];


            stats1DataTable.Columns.Add("IN", typeof(int));
            stats1DataTable.Columns.Add("OUT", typeof(int));

            stats2DataTable.Columns.Add("IN", typeof(int));
            stats2DataTable.Columns.Add("OUT", typeof(int));


            string[] rows = { "Ethernet II", "IPv4", "ICMP", "ARP", "UDP", "TCP", "HTTP", "HTTPS", "TOTAL"};
            string[] columns = { "IN", "OUT" };

            for (int i = 0; i < rows.Length; i++)
            {
                dataRowsIntf1[i] = stats1DataTable.NewRow();
                dataRowsIntf2[i] = stats2DataTable.NewRow();

                foreach (string col  in columns)
                {
                    dataRowsIntf1[i][col] = 0;
                    dataRowsIntf2[i][col] = 0;

                }

                stats1DataTable.Rows.Add(dataRowsIntf1[i]);
                stats2DataTable.Rows.Add(dataRowsIntf2[i]);

            }

            mainWindow.statistics1.DataSource = stats1DataTable;
            mainWindow.statistics2.DataSource = stats2DataTable;

            for (int i = 0; i < rows.Length; i++)
            {
                mainWindow.statistics1.Rows[i].HeaderCell.Value = rows[i];
                mainWindow.statistics2.Rows[i].HeaderCell.Value = rows[i];
            }
            mainWindow.statistics1.Columns["IN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mainWindow.statistics1.Columns["OUT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mainWindow.statistics2.Columns["IN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mainWindow.statistics2.Columns["OUT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            mainWindow.statistics1.Columns["IN"].Width = 75;
            mainWindow.statistics1.Columns["OUT"].Width = 75;
            mainWindow.statistics2.Columns["IN"].Width = 75;
            mainWindow.statistics2.Columns["OUT"].Width = 75;


        }

        private static List<PacketDotNet.Packet> disectPacket(PacketDotNet.Packet packet)
        {
            List<PacketDotNet.Packet> unravelledPacket = new List<PacketDotNet.Packet> ();
            while (packet.PayloadPacket != null)
            {
                unravelledPacket.Add(packet.PayloadPacket);
                packet = packet.PayloadPacket;
            }

            return unravelledPacket;
        }

        public static void updateStatsTable(PacketDotNet.Packet capturedPacket, int interfaceID, string inOut)
        {
            DataTable statsDataTable = (interfaceID == 1) ? stats1DataTable : stats2DataTable;
            object tableLock = (interfaceID == 1) ? stats1DataTableLock : stats2DataTableLock;

            try
            {
                lock(tableLock)
                {
                    if (capturedPacket == null)
                    {
                        return;
                    }
                       
                    lock(tableLock)
                    {
                        statsDataTable.Rows[0].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[0][inOut]) + 1);

                    }

                    lock (tableLock)
                    {
                        setValuesInTable(statsDataTable, capturedPacket, inOut);

                    }
                }
                
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error: {}", e.Message);
            } 
            
        }

        private static void setValuesInTable(DataTable statsDataTable, Packet capturedPacket, string inOut) 
        {
            List<PacketDotNet.Packet> unravelledPacket = new List<PacketDotNet.Packet>();

            if (capturedPacket is PacketDotNet.EthernetPacket)
            {

                unravelledPacket = disectPacket(capturedPacket);
                //statsDataTable.Rows[0].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[0][inOut]) + 1);

                foreach (PacketDotNet.Packet payload in unravelledPacket)
                {
                    switch (payload.GetType().Name)
                    {
                        case nameof(PacketDotNet.IPv4Packet):
                        case nameof(PacketDotNet.IPv6Packet):
                            statsDataTable.Rows[1].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[1][inOut]) + 1);
                            break;

                        case nameof(PacketDotNet.ArpPacket):
                            statsDataTable.Rows[3].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[3][inOut]) + 1);
                            break;

                        case nameof(PacketDotNet.IcmpV4Packet):
                        case nameof(IcmpV6Packet):
                            statsDataTable.Rows[2].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[2][inOut]) + 1);
                            break;

                        case nameof(PacketDotNet.TcpPacket):
                            statsDataTable.Rows[5].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[5][inOut]) + 1);
                            var tcpPayload = (TcpPacket)payload;
                            if (tcpPayload.DestinationPort == 80)
                            {
                                statsDataTable.Rows[6].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[6][inOut]) + 1);

                            }

                            else if (tcpPayload.DestinationPort == 443)
                            {
                                statsDataTable.Rows[7].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[7][inOut]) + 1);

                            }
                            break;

                        case nameof(PacketDotNet.UdpPacket):
                            statsDataTable.Rows[4].SetField(inOut, Convert.ToInt32(statsDataTable.Rows[4][inOut]) + 1);
                            break;
                    }

                }
            }
        }

        

    }
}
