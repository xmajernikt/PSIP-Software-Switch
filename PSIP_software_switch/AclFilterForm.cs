using PacketDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSIP_software_switch
{
    public partial class AclFilterForm : Form
    {
        private MainWindow mainWindow;
        private int addOrUpdate;
        private AclContainer aclRecord;

        public AclFilterForm(MainWindow _mainWindow, int _addOrUpdate, int _priority = 0, 
            string _verdict = "", string _port = "ANY", string _direction = "", 
            string _srcMac = "ANY", string _dstMac = "ANY", string _srcIp = "ANY", 
            string _dstIp = "ANY", int _srcPort = 0, int _dstPort = 0, string _ethType = "ANY", 
            string _icmpType = "ANY", string _protocol = "ANY", AclContainer _aclRecord = null)
        {
            mainWindow = _mainWindow;
            addOrUpdate = _addOrUpdate;
            aclRecord = _aclRecord;
            InitializeComponent();
            numericUpDownPriority.Value = _priority;
            aclRecord = _aclRecord;
            if (_verdict.Equals("Allow"))
            {
                allowRadioButton.Checked = true;
            }
            else if (_verdict.Equals("Deny"))
            {
                denyRadioButton.Checked = true;
            }

            comboBoxPort.SelectedItem = _port;

            if (_direction.Equals("IN/OUT"))
            {
                InCheckBox.Checked = true;
                outCheckBox.Checked = true;
            }
            else if ( _direction.Equals("IN"))
            {
                InCheckBox.Checked = true;
                outCheckBox.Checked = false;
            }
            else if (_direction.Equals("OUT")) 
            {
                InCheckBox.Checked = false;
                outCheckBox.Checked = true;
            }

            srcMacTextBox.Text = _srcMac;
            dstMacTextBox.Text = _dstMac;
            srcIPTextBox.Text = _srcIp;
            dstIPTextBox.Text = _dstIp;
            numericUpDownSrcPort.Value = _srcPort;
            numericUpDownDstPort.Value = _dstPort;

            comboBoxEthType.SelectedItem = _ethType;
            comboBoxICMP.SelectedItem = _icmpType;
            comboBoxProtocol.SelectedItem = _protocol;

            //priority = _priority == 0 ? 0 : _priority;
            //verdict = _verdict.Equals("") ? "" : _verdict;
            //comboBoxPort.SelectedIndex = 0;
            //comboBoxEthType.SelectedIndex = 0;
            //comboBoxProtocol.SelectedIndex = 0;
            //comboBoxICMP.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addAclRecord_Click(object sender, EventArgs e)
        {
            string allowDeny = allowRadioButton.Checked ? "Allow" : "Deny";
            string inOut = "";
            if (InCheckBox.Checked && outCheckBox.Checked)
            {
                inOut = "IN/OUT";
            }
            else if(InCheckBox.Checked && !outCheckBox.Checked)
            {
                inOut = "IN";
            }
            else if (!InCheckBox.Checked && outCheckBox.Checked)
            {
                inOut = "OUT";
            }
           
            AclContainer aclContainer = new AclContainer
            {
                Priority = (int)numericUpDownPriority.Value,
                Verdict = allowDeny,
                Direction = inOut,
                PortInterface = comboBoxPort.SelectedItem.ToString(),
                SrcMac = srcMacTextBox.Text,
                DstMac = dstMacTextBox.Text,
                SrcIp = srcIPTextBox.Text,
                DstIp = dstIPTextBox.Text,
                EthType = comboBoxEthType.SelectedItem.ToString(),
                SrcPort = (int)numericUpDownSrcPort.Value,
                DstPort = (int)numericUpDownDstPort.Value,
                ICMPtype = comboBoxICMP.SelectedItem.ToString(),
                Protocol = comboBoxProtocol.SelectedItem.ToString(),
            };
            if (addOrUpdate == 1) { ACL.AddToList(aclContainer); }
            else
            {
                aclRecord.Priority = (int)numericUpDownPriority.Value;
                aclRecord.Verdict = allowDeny;
                aclRecord.Direction = inOut;
                aclRecord.PortInterface = comboBoxPort.SelectedItem.ToString();
                aclRecord.SrcMac = srcMacTextBox.Text;
                aclRecord.DstMac = dstMacTextBox.Text;
                aclRecord.SrcIp = srcIPTextBox.Text;
                aclRecord.DstIp = dstIPTextBox.Text;
                aclRecord.EthType = comboBoxEthType.SelectedItem.ToString();
                aclRecord.SrcPort = (int)numericUpDownSrcPort.Value;
                aclRecord.DstPort = (int)numericUpDownDstPort.Value;
                aclRecord.ICMPtype = comboBoxICMP.SelectedItem.ToString();
                aclRecord.Protocol = comboBoxProtocol.SelectedItem.ToString();
            }
            ACL.SortList();
            Close();
           
            Syslog.EnqueuePacket("A new ACL record has been added", Syslog.SyslogSeverity.Informational);
        }
    }
}
