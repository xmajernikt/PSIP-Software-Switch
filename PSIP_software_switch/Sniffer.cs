using SharpPcap;
using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Drawing;


namespace PSIP_software_switch
{
    internal class Sniffer
    {
        static MainWindow mainWindow;
        public static int deviceIndex1 = -1;
        public static int deviceIndex2 = -1;
        public static SharpPcap.CaptureDeviceList devices;
        private int packetCount;
        private static List<int> openDevices = new List<int>();
        private static Dictionary<string, int> interfaceToID = new Dictionary<string, int>();
        public static Queue<QueedPacket> packets = new Queue<QueedPacket>();
        private static bool thredShouldTerminate = false;
        private static Dictionary<string, int> macHashTable = new Dictionary<string, int>();
        private static Dictionary<int, int> portToDevIndex = new Dictionary<int, int>();
        private static Dictionary<int, string> devIndexToName = new Dictionary<int, string>();
        public static object QueueLock = new object();
        private static Thread backroundThread;
        public static DateTime packetArrivalTimeDev1;
        public static DateTime packetArrivalTimeDev2;
        private static System.Windows.Forms.Timer timer;
        private int disconnectTime = 5;
        private bool isDisconnectedInt1 = true;
        private bool isDisconnectedInt2 = true;


        public Sniffer(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            collectDevices();
            


        }

        private void collectDevices()
        {
            devices = CaptureDeviceList.Instance;

            packetCount = 0;

            foreach (var device in devices)
            {
                mainWindow.selectionInterface1.Items.Add(device.Description);
                mainWindow.selectionInterface2.Items.Add(device.Description);
            }


            mainWindow.selectionInterface1.SelectedIndexChanged += SelectionInterface1_ChangeDetected;
            mainWindow.selectionInterface2.SelectedIndexChanged += SelectionInterface2_ChangeDetected;
        }

        private void startPacketProcessingThread()
        {
            backroundThread = new Thread(() => ProcessPackets(ref packets, ref QueueLock, ref thredShouldTerminate));
            backroundThread.Start();
        }

        private void SelectionInterface1_ChangeDetected(object sender, EventArgs e)
        {
            deviceIndex1 = mainWindow.selectionInterface1.SelectedIndex;
            mainWindow.interface1ConnectionLabel.ForeColor = Color.OrangeRed;
            mainWindow.interface1ConnectionLabel.Text = "Selected";
            if (interfaceToID.ContainsKey(devices[deviceIndex1].Description))
            {
                interfaceToID.Remove(devices[deviceIndex1].Description);
            }

            if (deviceIndex2 != -1)
            {
                mainWindow.enableSyslogCheckbox.Enabled = true;
            }

            openDevices.Add(deviceIndex1);
            interfaceToID[devices[deviceIndex1].Description] = 1;
            devIndexToName[deviceIndex1] = "Interface 1";
            //portToDevIndex[1] = deviceIndex2;
           
        }

        private void SelectionInterface2_ChangeDetected(object sender, EventArgs e)
        {
            deviceIndex2 = mainWindow.selectionInterface2.SelectedIndex;
            mainWindow.interface2ConnectionLabel.ForeColor = Color.OrangeRed;
            mainWindow.interface2ConnectionLabel.Text = "Selected";
            if (interfaceToID.ContainsKey(devices[deviceIndex2].Description))
            {
                interfaceToID.Remove(devices[deviceIndex2].Description);
            }
            interfaceToID[devices[deviceIndex2].Description] = 2;
            devIndexToName[deviceIndex2] = "Interface 2";

            if (deviceIndex1 != -1)
            {
                mainWindow.enableSyslogCheckbox.Enabled = true;
               
            }

            //portToDevIndex[2] = deviceIndex1;
            openDevices.Add(deviceIndex2);
            
            

        }
        private void startSniffing()
        {
            startPacketProcessingThread();
            // deviceIndex2 = mainWindow.selectionInterface2.SelectedIndex;
            if (deviceIndex1 != -1 && deviceIndex2 != -1)
            {
                
                portToDevIndex[1] = deviceIndex2;
                portToDevIndex[2] = deviceIndex1;
                devices[deviceIndex1].OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
                onPacketArrivalCallBackInt1(sender, e, deviceIndex1, deviceIndex2));
                devices[deviceIndex2].OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
                onPacketArrivalCallBackInt1(sender, e, deviceIndex2, deviceIndex1));

                int timeoutMiliseconds = 1000;

                devices[deviceIndex1].Open(mode: DeviceModes.Promiscuous | DeviceModes.NoCaptureLocal | DeviceModes.MaxResponsiveness);
                devices[deviceIndex2].Open(mode: DeviceModes.Promiscuous | DeviceModes.NoCaptureLocal | DeviceModes.MaxResponsiveness);

                devices[deviceIndex1].StartCapture();
                devices[deviceIndex2].StartCapture();

               
            }
            
            startTimer();

        }

        private void onPacketArrivalCallBackInt1(object sender, PacketCapture e, int recvDeviceIndex, int sendDeviceIndex)
        {

           

            var time = e.Header.Timeval.Date;
            var len = e.Data.Length;
            var rawPacket = e.GetPacket();
            var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);


            if (interfaceToID[devices[recvDeviceIndex].Description] == 1)
            { 
                mainWindow.Invoke((MethodInvoker)delegate {
                    // Update UI on the UI thread
                    mainWindow.interface1ConnectionLabel.ForeColor = Color.Green;
                    mainWindow.interface1ConnectionLabel.Text = "Connected";
                });

                isDisconnectedInt1 = false;
                packetArrivalTimeDev1 = DateTime.UtcNow;

                
            }
            else if (interfaceToID[devices[recvDeviceIndex].Description] == 2)
            {

                mainWindow.Invoke((MethodInvoker)delegate {
                    // Update UI on the UI thread
                    mainWindow.interface2ConnectionLabel.ForeColor = Color.Green;
                    mainWindow.interface2ConnectionLabel.Text = "Connected";
                });
                isDisconnectedInt2 = false;
                packetArrivalTimeDev2 = DateTime.UtcNow;

                
            }


            if (packet is EthernetPacket ethPacket)
            {

                if (ACL.AclAllowPacket(ethPacket, devIndexToName[recvDeviceIndex], "IN"))
                {
                    lock (QueueLock)
                    {
                        packets.Enqueue(new QueedPacket(recvDeviceIndex, rawPacket));

                    }
                    Statistics.updateStatsTable(ethPacket, interfaceToID[devices[recvDeviceIndex].Description], "IN");

                    MacTable.addRow(ethPacket.SourceHardwareAddress.ToString(), interfaceToID[devices[recvDeviceIndex].Description]);
                }
                else
                {
                    Console.WriteLine("NEMOZE HAHAHAHAHHAHA");
                }
                
                

            }

        }

        private void ProcessPackets(ref Queue<QueedPacket> capturedPackets, ref object QueueLockObj, ref bool shouldTermiante)
        {
            while (!shouldTermiante)
            {
                bool shouldSleep = true;
                
                lock (QueueLockObj)
                {
                    if (capturedPackets.Count > 0)
                    {
                        shouldSleep = false;
                    }
                }

                if (shouldSleep)
                {
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    Queue<QueedPacket> tempPackets = null;

                    lock (QueueLockObj)
                    {
                        tempPackets = new Queue<QueedPacket>(capturedPackets);
                        capturedPackets.Clear();
                    }

                    foreach (QueedPacket packet in tempPackets)
                    {
                        int sendingDeviceIndex = (packet.deviceIndex == deviceIndex1) ? deviceIndex2 :
                            ((packet.deviceIndex == deviceIndex2) ? deviceIndex1 : -1);
                        int receivingDeviceIndex = (packet.deviceIndex == deviceIndex1) ? deviceIndex1 :
                            ((packet.deviceIndex == deviceIndex2) ? deviceIndex2 : -1);
                        bool isInMac = false;
                        if (sendingDeviceIndex == -1)
                        {
                            throw new Exception("Sending device invalid");
                        }

                       

                        if (!ACL.AclAllowPacket(packet.packet, devIndexToName[sendingDeviceIndex], "OUT")) 
                        {
                            continue;
                        }
                        isInMac = MacTable.inMacTable(packet.packet.DestinationHardwareAddress.ToString());
                        
                        int macTablePort = MacTable.GetRecordPort(packet.packet.SourceHardwareAddress.ToString());

                        if (macTablePort != 0)
                        {
                            
                            if (macTablePort != interfaceToID[devices[packet.deviceIndex].Description])
                            {
                                Syslog.EnqueuePacket("Cabels have been swapped", Syslog.SyslogSeverity.Alert);
                                MacTable.CableSwitch(packet.packet.SourceHardwareAddress.ToString(), 0, 0);
                                
                                //SwitchPortMapping();
                                
                            }
                        }

                        if (isInMac && packet.deviceIndex == sendingDeviceIndex)
                        {
                            mainWindow.macTableObj.updateTime(packet.packet.SourceHardwareAddress.ToString());

                            int toSend;
                            lock (MacTable.lockObject)
                            {
                                 toSend = portToDevIndex[MacTable.macHashTable[MacTable.FormatMac(packet.packet.DestinationHardwareAddress.ToString())]];

                            }
                           
                            try
                            {
                                Statistics.updateStatsTable(packet.packet, interfaceToID[devices[sendingDeviceIndex].Description], "OUT");

                                devices[toSend].SendPacket(packet.packet);
                                //devices[sendingDeviceIndex].SendPacket(packet.packet);


                            }
                            catch (Exception e) { }

                        }
                        
                        else
                        {
                            //MacTable.addRow(packet.packet.SourceHardwareAddress.ToString(), interfaceToID[devices[receivingDeviceIndex].Description]);
                            mainWindow.macTableObj.updateTime(packet.packet.SourceHardwareAddress.ToString());
                            foreach (int devInd in openDevices)
                            {
                                if (devInd != packet.deviceIndex)
                                {
                                    try
                                    {
                                        Statistics.updateStatsTable(packet.packet, interfaceToID[devices[sendingDeviceIndex].Description], "OUT");

                                        devices[devInd].SendPacket(packet.packet);
                                    }
                                    catch (Exception ex) { }
                                }

                                
                            }
                        }

                        if (isInMac)
                        {
                            mainWindow.macTableObj.updateTime(packet.packet.SourceHardwareAddress.ToString());

                        }




                    }
                }
            }

        }


        public static void stopSniffing()
        {
            if (deviceIndex1 != -1 && deviceIndex2 != -1)
            {
                if (devices[deviceIndex1] != null && devices[deviceIndex2] != null)
                {

                    mainWindow.Invoke((MethodInvoker)delegate {
                        // Update UI on the UI thread
                        mainWindow.interface1ConnectionLabel.ForeColor = Color.Red;
                        mainWindow.interface1ConnectionLabel.Text = "Disconnected";
                    });

                    mainWindow.Invoke((MethodInvoker)delegate {
                        // Update UI on the UI thread
                        mainWindow.interface2ConnectionLabel.ForeColor = Color.Red;
                        mainWindow.interface2ConnectionLabel.Text = "Disconnected";
                    });

                    Syslog.EnqueuePacket("Switch is disabled", Syslog.SyslogSeverity.Informational);
                    timer.Stop();
                    devices[deviceIndex1].StopCapture();
                    devices[deviceIndex2].StopCapture();
                    devices[deviceIndex1].Close();
                    devices[deviceIndex2].Close();
                    thredShouldTerminate = true;
                    backroundThread.Join();
                }
            }


        }
        public void startSniffingMethod()
        {
            if (deviceIndex1 != -1 && deviceIndex2 != -1)
            {
                if (devices[deviceIndex1] != null && devices[deviceIndex2] != null)
                {
                    thredShouldTerminate = false;
                    startSniffing();
                    Syslog.EnqueuePacket("Switch is enabled", Syslog.SyslogSeverity.Informational);

                }
            }
        }

        private static byte[] GetRandomPacket()
        {
            byte[] packet = new byte[200];
            Random rand = new Random();
            rand.NextBytes(packet);
            return packet;
        }

        public struct QueedPacket
        {
            public EthernetPacket packet { get; set; }
            public int deviceIndex { get; set; }
            public string acl { get; set; }

            public QueedPacket(int deviceIndex, RawCapture packet, string acl =  "")
            {
                this.deviceIndex = deviceIndex;
                this.packet = (EthernetPacket)Packet.ParsePacket(packet.LinkLayerType, packet.Data);
                this.acl = acl;
            }

            public QueedPacket(int deviceIndex, EthernetPacket syslogPacket, string acl = "acl")
            {
                this.deviceIndex = deviceIndex;
                this.packet = (EthernetPacket)syslogPacket;
                this.acl = acl;
            }
        }


        public void CheckTime(object sender, EventArgs e)
        {
            // Define the interval for checking in milliseconds (e.g., every 2 seconds)
           
            DateTime currentTime = DateTime.UtcNow;
            double dev1TimeDifference = (currentTime - packetArrivalTimeDev1).TotalSeconds ;
            double dev2TimeDifference = (currentTime - packetArrivalTimeDev2).TotalSeconds;
            
            if (dev1TimeDifference > disconnectTime && !isDisconnectedInt1)
            {
                Syslog.EnqueuePacket("Interface 1 has been disconnect", Syslog.SyslogSeverity.Warning);
                //devices[deviceIndex1].StopCapture();
                //devices[deviceIndex1].Close();
                mainWindow.interface1ConnectionLabel.ForeColor = Color.Red;
                mainWindow.interface1ConnectionLabel.Text = "Disconnected";
                isDisconnectedInt1 = true;
                MacTable.DeleteSpecificRecords(1);
               

            }
            if (dev2TimeDifference > disconnectTime && !isDisconnectedInt2)
            {
                Syslog.EnqueuePacket("Interface 2 has been disconnect", Syslog.SyslogSeverity.Warning);

                //devices[deviceIndex2].StopCapture();
                //devices[deviceIndex2].Close();
                mainWindow.interface2ConnectionLabel.ForeColor = Color.Red;
                mainWindow.interface2ConnectionLabel.Text = "Disconnected";
                isDisconnectedInt2 = true;
                MacTable.DeleteSpecificRecords(2);
                
            }

            // Wait for the specified interval before checking again
            
        }

        public static ILiveDevice SyslogSenderDevice()
        {
            ILiveDevice senderDevice = null;
            if (mainWindow.interface1RadioButton.Checked)
            {
                senderDevice = devices[deviceIndex1];
            }
            else if (mainWindow.interface2RadioButton.Checked)
            {
                senderDevice = devices[deviceIndex2];
            }

            return senderDevice;
        }

        public void SetDisconnectTime(int newTime)
        {
            disconnectTime = newTime;
            
        }

        private void startTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 700; // 1 second
            timer.Tick += CheckTime;
            timer.Start();
        }

        public static void ClearBuffer()
        {
            if (packets != null)
            {
                packets.Clear();
            }
        }
    }

}


