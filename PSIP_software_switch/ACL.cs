using PacketDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{

    internal class ACL
    {

        private static MainWindow mainWindow;
        
        private static BindingList<AclContainer> aclList = new BindingList<AclContainer> ();
        private static BindingList<AclContainer> sortedListInstance;
            
           

        public ACL(MainWindow _mainWindow) 
        { 
            mainWindow = _mainWindow;
            mainWindow.ACLtable.DataSource = aclList;
            ResizeColumns ();
            


        }

        private enum ICMPtypes
        {
            EchoReply = 0,
            EchoRequest = 8,
            
        }

        private void ResizeColumns()
        {
      
            mainWindow.ACLtable.Columns["Priority"].Width = 50;
            mainWindow.ACLtable.Columns["Verdict"].Width = 50;
            mainWindow.ACLtable.Columns["Direction"].Width = 60;
            mainWindow.ACLtable.Columns["PortInterface"].Width = 90;
            mainWindow.ACLtable.Columns["SrcMac"].Width = 120;
            mainWindow.ACLtable.Columns["DstMac"].Width = 120;
            mainWindow.ACLtable.Columns["SrcIp"].Width = 90;
            mainWindow.ACLtable.Columns["DstIp"].Width = 90;
            mainWindow.ACLtable.Columns["EthType"].Width = 60;
            mainWindow.ACLtable.Columns["SrcPort"].Width = 65;
            mainWindow.ACLtable.Columns["DstPort"].Width = 65;
            mainWindow.ACLtable.Columns["ICMPtype"].Width = 65;
            mainWindow.ACLtable.Columns["Protocol"].Width = 70;




        }

        public static void AddToList(AclContainer newRecord) { aclList.Add(newRecord); }

        public static void SortList()
        {
            sortedListInstance = new BindingList<AclContainer>(aclList.OrderByDescending(x => x.Priority).ToList());
            aclList = sortedListInstance;
            mainWindow.ACLtable.DataSource = aclList;
            //aclList = sortedListInstance;

        }

        public static AclContainer GetRecord(int index)
        {
            return sortedListInstance[index];
        }

        public void DeleteRecord(int index)
        {
            sortedListInstance.RemoveAt(index);
            mainWindow.ACLtable.DataSource = sortedListInstance;

        }

        public static bool AclAllowPacket(EthernetPacket ethPacket, string interfaceId, string inOut)
        {
            if (mainWindow.ACLtable.Rows.Count > 0 && mainWindow.enableAclCheckBox.Checked)
            {
                foreach (AclContainer acl in sortedListInstance)
                {
                    if (!acl.PortInterface.Equals("ANY") && !acl.PortInterface.Equals(interfaceId))
                        continue;

                    Console.WriteLine(interfaceId);

                    if (!acl.Direction.Equals("IN/OUT") && !acl.Direction.Equals(inOut))
                        continue;

                    Console.WriteLine(inOut);

                    if (!acl.SrcMac.Equals("ANY") && !acl.SrcMac.Equals(MacTable.FormatMac(ethPacket.SourceHardwareAddress.ToString())))
                        continue;

                    Console.WriteLine("SRC MAC");

                    if (!acl.DstMac.Equals("ANY") && !acl.DstMac.Equals(MacTable.FormatMac(ethPacket.DestinationHardwareAddress.ToString())))
                        continue;

                    //if (!acl.EthType.Equals("ANY") && !acl.EthType.Equals("IPv4"))
                    //{
                    //    continue;
                    //}

                    if (ethPacket.PayloadPacket is IPPacket)
                    {
                        IPPacket ipPacket = (IPPacket)ethPacket.PayloadPacket;
                        if (!acl.EthType.Equals("ANY") && !acl.EthType.Equals(ethPacket.PayloadPacket.GetType().Name.Replace("Packet", "")))
                            continue;

                        Console.WriteLine("IPv4");


                        if (!acl.SrcIp.Equals("ANY") && !acl.SrcIp.Equals(ipPacket.SourceAddress.ToString()))
                            continue;
                        if (!acl.DstIp.Equals("ANY") && !acl.DstIp.Equals(ipPacket.DestinationAddress.ToString()))
                            continue;

                        if (ipPacket.PayloadPacket is IcmpV4Packet icmpV4Packet)
                        {
                            if (!acl.Protocol.Equals("ANY") && !acl.Protocol.Equals("ICMP")) continue;

                            Console.WriteLine("ICMP");
                            Console.WriteLine(icmpV4Packet.TypeCode);
                            
                            if (!acl.ICMPtype.Equals("ANY") && !acl.ICMPtype.Equals(icmpV4Packet.TypeCode.ToString())) continue;

                            if (acl.Verdict.Equals("Allow")) return true;
                            Console.WriteLine("Deny");
                            return false;
                            

                        }

                        if (ipPacket.PayloadPacket is TcpPacket tcpPacket)
                        {
                            if (!acl.Protocol.Equals("ANY") && !acl.Protocol.Equals("TCP")) continue;

                            Console.WriteLine("TCP");
                            Console.WriteLine(tcpPacket.DestinationPort);
                            if (!(acl.SrcPort == 0) && !(acl.SrcPort == tcpPacket.SourcePort)) continue;

                            if (!(acl.DstPort == 0) && !(acl.DstPort == tcpPacket.DestinationPort)) continue;
                            Console.WriteLine("PORT");
                            if (acl.Verdict.Equals("Allow")) return true;
                            return false;
                        }

                        if (ipPacket.PayloadPacket is UdpPacket udpPacket)
                        {
                            if (!acl.Protocol.Equals("ANY") && !acl.Protocol.Equals("UDP")) continue;

                            if (!(acl.SrcPort == 0) && !(acl.SrcPort == udpPacket.SourcePort)) continue;

                            if (!(acl.DstPort == 0) && !(acl.DstPort == udpPacket.DestinationPort)) continue;

                            if (acl.Verdict.Equals("Allow")) return true;
                            return false;
                        }

                        if (acl.Protocol.Equals("ANY"))
                        {
                            if (acl.Verdict.Equals("Allow")) return true;
                            return false;
                        }
                    }

                    if (ethPacket.PayloadPacket is ArpPacket arpPacket)
                    {
                        Console.WriteLine(arpPacket.GetType().Name);
                        if (!acl.EthType.Equals("ANY") && !acl.EthType.Equals("ARP"))
                            continue;

                        if (acl.Verdict.Equals("Allow")) return true;
                        return false;
                    }


                }

                return true;
            }
            return true;
            
        }
    }


}
