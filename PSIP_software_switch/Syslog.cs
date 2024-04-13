using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PSIP_software_switch
{
    public class Syslog
    {
        private static MainWindow mainWindow;
        private static IPAddress serverIp;
        private static ushort serverPort;
        private static IPAddress clientIp;
        private static ushort clientPort;
        private static UdpPacket udpPacket;
        private static PhysicalAddress serverMac = PhysicalAddress.Parse("FF-FF-FF-FF-FF-FF");
        private static ILiveDevice sender;

        public Syslog(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
        }

        public static void StartSyslog(IPAddress _serverIp, IPAddress _clientIp, ushort _clientPort, ushort _serverPort)
        {
            serverIp = _serverIp;
            serverPort = _serverPort;
            clientIp = _clientIp;
            clientPort = _clientPort;
            sender = Sniffer.SyslogSenderDevice();

        }

        private static EthernetPacket BuildSyslogPacket(string message, SyslogSeverity severity)
        {
            // Constructing the syslog message
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");
            string hostName = Environment.MachineName;
            string appName = "Switch"; // Change this to your application name
            string procId = "12345"; 
            string msgId = "-";
            string structuredData = "-";
            string data = $"<{((int)severity)}>1 {timestamp} {hostName} {appName} {procId} {msgId} [{structuredData}] {message}";

            var udpPacket = new UdpPacket(0, serverPort)
            {
                PayloadData = Encoding.UTF8.GetBytes(data)
            };

            var ipPacket = new IPv4Packet(clientIp, serverIp)
            {
                Protocol = PacketDotNet.ProtocolType.Udp,
                PayloadPacket = udpPacket
            };
            Console.WriteLine(sender);
            var ethPacket = new EthernetPacket(sender.MacAddress, serverMac, EthernetType.IPv4)
            {
                PayloadPacket = ipPacket
            };

            return ethPacket;
        }

        

        public static void EnqueuePacket(string message, SyslogSeverity syslogSeverity)
        {
            if (mainWindow.syslogControl != null)
            {
                if (mainWindow.syslogControl.Enabled && mainWindow.enableSyslogCheckbox.Checked)
                {
                    try
                    {
                        Sniffer.devices[mainWindow.syslogDeviceSender].SendPacket(BuildSyslogPacket(message, syslogSeverity));

                    } catch (Exception e) { }

                }
            }
           
          
        }

        public enum SyslogSeverity
        {
            Emergency = 0,
            Alert = 1,
            Critical = 2,
            Error = 3,
            Warning = 4,
            Notice = 5,
            Informational = 6,
            Debug = 7
        }


    }
}
