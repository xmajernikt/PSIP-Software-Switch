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

namespace PSIP_software_switch
{
    internal class Sniffer
    {
        MainWindow mainWindow;
        private static int deviceIndex1 = -1;
        private static int deviceIndex2 = -1;
        private static SharpPcap.CaptureDeviceList devices;
        private int packetCount;
        private static List<int> openDevices = new List<int>();
        private static Dictionary<string, int> interfaceToID = new Dictionary<string, int>();
        private static Queue<QueedPacket> packets = new Queue<QueedPacket>();
        private static bool thredShouldTerminate = false;
        private static Dictionary<string, int> macHashTable = new Dictionary<string, int>();
        private static object QueueLock = new object();
        private static Thread backroundThread;

        public Sniffer(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            collectDevices();
            startPacketProcessingThread();



        }

        private void collectDevices()
        {
            devices = CaptureDeviceList.Instance;

            packetCount = 0;
            Console.WriteLine(devices);

            foreach (var device in devices)
            {
                mainWindow.selectionInterface1.Items.Add(device.Description);
                mainWindow.selectionInterface2.Items.Add(device.Description);
            }

            Console.WriteLine(deviceIndex1 = mainWindow.selectionInterface1.SelectedIndex);

            mainWindow.selectionInterface1.SelectedIndexChanged += SelectionInterface1_ChangeDetected;
            mainWindow.selectionInterface2.SelectedIndexChanged += SelectionInterface2_ChangeDetected;
        }

        private static void startPacketProcessingThread()
        {
            backroundThread = new Thread(() => ProcessPackets(ref packets, ref QueueLock, ref thredShouldTerminate));
            backroundThread.Start();
        }

        private void SelectionInterface1_ChangeDetected(object sender, EventArgs e)
        {
            deviceIndex1 = mainWindow.selectionInterface1.SelectedIndex;
            if (interfaceToID.ContainsKey(devices[deviceIndex1].Description))
            {
                interfaceToID.Remove(devices[deviceIndex1].Description);
            }
            openDevices.Add(deviceIndex1);
            interfaceToID[devices[deviceIndex1].Description] = 1;
            if (deviceIndex1 != -1 && deviceIndex2 != -1)
            {

                startSniffing();
            }

        }

        private void SelectionInterface2_ChangeDetected(object sender, EventArgs e)
        {
            deviceIndex2 = mainWindow.selectionInterface2.SelectedIndex;

            if (interfaceToID.ContainsKey(devices[deviceIndex2].Description))
            {
                interfaceToID.Remove(devices[deviceIndex2].Description);
            }
            interfaceToID[devices[deviceIndex2].Description] = 2;
            openDevices.Add(deviceIndex2);
            if (deviceIndex1 != -1 && deviceIndex2 != -1)
            {
                startSniffing();
            }
            else
            {

            }

        }
        private void startSniffing()
        {
            // deviceIndex2 = mainWindow.selectionInterface2.SelectedIndex;

            devices[deviceIndex1].OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
            onPacketArrivalCallBackInt1(sender, e, deviceIndex1, deviceIndex2));
            devices[deviceIndex2].OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
            onPacketArrivalCallBackInt1(sender, e, deviceIndex2, deviceIndex1));
            int timeoutMiliseconds = 1000;

            devices[deviceIndex1].Open(mode: DeviceModes.Promiscuous | DeviceModes.NoCaptureLocal | DeviceModes.MaxResponsiveness, timeoutMiliseconds);
            devices[deviceIndex2].Open(mode: DeviceModes.Promiscuous | DeviceModes.NoCaptureLocal | DeviceModes.MaxResponsiveness, timeoutMiliseconds);

            devices[deviceIndex1].StartCapture();
            devices[deviceIndex2].StartCapture();
        }

        private void onPacketArrivalCallBackInt1(object sender, PacketCapture e, int recvDeviceIndex, int sendDeviceIndex)
        {
            var time = e.Header.Timeval.Date;
            var len = e.Data.Length;
            var rawPacket = e.GetPacket();
            var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);
            if (packet is EthernetPacket ethPacket)
            {
                MacTable.addRow(ethPacket.SourceHardwareAddress.ToString(), interfaceToID[devices[recvDeviceIndex].Description]);
                packets.Enqueue(new QueedPacket(recvDeviceIndex, rawPacket));

                //if (macHashTable.ContainsKey(ethPacket.DestinationHardwareAddress.ToString()))
                //{
                //    Console.WriteLine("HAHAHHAHA");
                //    if (macHashTable[ethPacket.DestinationHardwareAddress.ToString()] != recvDeviceIndex)
                //    {
                //        Console.WriteLine("PAPPAPAP");
                //        Console.WriteLine(ethPacket.SourceHardwareAddress.ToString());
                //        Console.WriteLine(recvDeviceIndex);
                //        Console.WriteLine(macHashTable[ethPacket.DestinationHardwareAddress.ToString()]);
                //        Console.WriteLine(devices[macHashTable[ethPacket.DestinationHardwareAddress.ToString()]]);
                //        devices[macHashTable[ethPacket.DestinationHardwareAddress.ToString()]].SendPacket(ethPacket);
                //        Statistics.updateStatsTable(ethPacket, interfaceToID[devices[recvDeviceIndex].Description], "IN");

                //        Statistics.updateStatsTable(ethPacket, interfaceToID[devices[recvDeviceIndex].Description], "OUT");
                //        //return;

                //    }
                //}
                //else if (!macHashTable.ContainsKey(ethPacket.DestinationHardwareAddress.ToString()))
                //{
                //    MacTable.addRow(ethPacket.SourceHardwareAddress.ToString(), interfaceToID[devices[recvDeviceIndex].Description]);
                //    Console.WriteLine("LALALAL");
                //    Console.WriteLine(ethPacket.SourceHardwareAddress.ToString());
                //    Console.WriteLine(ethPacket.DestinationHardwareAddress.ToString());

                //    Console.WriteLine(sendDeviceIndex);
                //    macHashTable[ethPacket.SourceHardwareAddress.ToString()] = recvDeviceIndex;
                //    devices[sendDeviceIndex].SendPacket(ethPacket);
                //    Statistics.updateStatsTable(ethPacket, interfaceToID[devices[recvDeviceIndex].Description], "IN");

                //    Statistics.updateStatsTable(ethPacket, interfaceToID[devices[recvDeviceIndex].Description], "OUT");

                //}
            }


            if (recvDeviceIndex == deviceIndex1)
            {
                // Statistics.updateStatsTable(packet, interfaceToID[devices[recvDeviceIndex].Description], "IN");
                // devices[sendDeviceIndex].SendPacket(packet);
                // Statistics.updateStatsTable(packet, interfaceToID[devices[recvDeviceIndex].Description], "OUT");
            }
            else
            {
                // Statistics.updateStatsTable(packet, interfaceToID[devices[recvDeviceIndex].Description], "IN");
            }

        }

        private static void ProcessPackets(ref Queue<QueedPacket> capturedPackets, ref object QueueLockObj, ref bool shouldTermiante)
        {
            while (!shouldTermiante)
            {
                bool shouldSleep = true;
                bool isInMac = false;
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

                        if (sendingDeviceIndex == -1)
                        {
                            throw new Exception("Sending device invalid");
                        }
                        isInMac = MacTable.inMacTable(packet.packet.DestinationHardwareAddress.ToString());
                        if (isInMac)
                        {

                            devices[sendingDeviceIndex].SendPacket(packet.packet);


                        }
                        else
                        {
                            foreach (int devInd in openDevices)
                            {
                                if (devInd == packet.deviceIndex)
                                {
                                    continue;
                                }

                                try
                                {
                                    devices[devInd].SendPacket(packet.packet); break;
                                }
                                catch (Exception ex) { }
                            }
                        }
                        Statistics.updateStatsTable(packet.packet, interfaceToID[devices[packet.deviceIndex].Description], "IN");

                        Statistics.updateStatsTable(packet.packet, interfaceToID[devices[packet.deviceIndex].Description], "OUT");



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
                    startSniffing();
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

        private struct QueedPacket
        {
            public EthernetPacket packet { get; set; }
            public int deviceIndex { get; set; }

            public QueedPacket(int deviceIndex, RawCapture packet)
            {
                this.deviceIndex = deviceIndex;
                this.packet = (EthernetPacket)Packet.ParsePacket(packet.LinkLayerType, packet.Data);
            }
        }

    }
}
