using SharpPcap;
using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace PSIP_software_switch
{
    internal class Sniffer
    {
        MainWindow mainWindow;
        private static int deviceIndex1 = -1;
        private static int deviceIndex2 = -1;
        private static SharpPcap.CaptureDeviceList devices;
        private int packetCount;
        private static Dictionary<string, int> interfaceToID = new Dictionary<string, int> ();
        private static Queue<QueedPacket> packets = new Queue<QueedPacket> ();
        private static bool thredShouldTerminate = false;
        private static Hashtable macHashTable = new Hashtable ();
        private static readonly object QueueLock = new object ();

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
            var backroundThread = new System.Threading.Thread(ProcessPackets);
            backroundThread.Start();
        }

        private void SelectionInterface1_ChangeDetected(object sender, EventArgs e)
        {
            deviceIndex1 = mainWindow.selectionInterface1.SelectedIndex;
            if (interfaceToID.ContainsKey(devices[deviceIndex1].Description))
            {
                interfaceToID.Remove(devices[deviceIndex1].Description);
            }
            
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

            devices[deviceIndex1].OnPacketArrival += new PacketArrivalEventHandler( (sender, e) => 
            onPacketArrivalCallBackInt1(sender, e, deviceIndex1, deviceIndex2));
            devices[deviceIndex2].OnPacketArrival += new PacketArrivalEventHandler((sender, e) =>
            onPacketArrivalCallBackInt1(sender, e, deviceIndex2, deviceIndex1));
            int timeoutMiliseconds = 1000;

            devices[deviceIndex1].Open(mode: DeviceModes.Promiscuous, timeoutMiliseconds);
            devices[deviceIndex2].Open(mode: DeviceModes.Promiscuous, timeoutMiliseconds);

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
                if (!macHashTable.ContainsKey(ethPacket.SourceHardwareAddress.ToString()))
                {
                    macHashTable.Add(ethPacket.SourceHardwareAddress.ToString(), recvDeviceIndex);

                }
                //MacTable.updateMacTable(ethPacket.SourceHardwareAddress.ToString(), 0);
            }
            lock (QueueLock)
            {
                packets.Enqueue(new QueedPacket(recvDeviceIndex, rawPacket));
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

        private static void ProcessPackets()
        {
            while (!thredShouldTerminate)
            {
                bool shouldSleep = true;

                lock (QueueLock)
                {
                    if (packets.Count > 0)
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
                    Queue<QueedPacket> tempPackets = new Queue<QueedPacket>();

                    lock (QueueLock)
                    {
                        tempPackets = packets;
                        packets = new Queue<QueedPacket> ();
                    }

                    foreach (QueedPacket packet in tempPackets)
                    {
                        int sendingDeviceIndex = (packet.deviceIndex == deviceIndex1) ? deviceIndex2 :
                            ((packet.deviceIndex == deviceIndex2) ? deviceIndex1 : -1);
                        int receivingDevice = (packet.deviceIndex == deviceIndex1) ? deviceIndex1:
                            ((packet.deviceIndex == deviceIndex2) ? deviceIndex2 : -1);

                        if (sendingDeviceIndex == -1)
                        {
                            throw new Exception("Sending device invalid");
                        }
                        if (macHashTable.ContainsKey(packet.packet.SourceHardwareAddress.ToString()))
                        {
                            if ((int)macHashTable[packet.packet.SourceHardwareAddress.ToString()] == receivingDevice)
                            {
                                devices[sendingDeviceIndex].SendPacket(packet.packet);
                                Statistics.updateStatsTable(packet.packet, interfaceToID[devices[packet.deviceIndex].Description], "IN");

                                Statistics.updateStatsTable(packet.packet, interfaceToID[devices[packet.deviceIndex].Description], "OUT");
                            }
                        }
                        

                    }
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
