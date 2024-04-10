using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSIP_software_switch
{
    public class AclContainer
    {
        public int Priority { get; set; }
        public string Verdict { get; set; }
        public string Direction { get; set; }
        public string PortInterface { get; set; }
        public string SrcMac { get; set; }
        public string DstMac { get; set; }
        public string SrcIp { get; set; }
        public string DstIp { get; set; }
        public string EthType { get; set; }
        public int SrcPort { get; set; }
        public int DstPort { get; set; }
        public string ICMPtype { get; set; }
        public string Protocol { get; set; }
        

    }
}
