using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    public partial class MainWindow : Form
    {
        private Statistics statisticsHandle;
        private Sniffer sniffer;
        public MacTable macTableObj;
        private ACL acl;
        private Syslog syslog;
        public bool interface1RadioButtonState = true;
        public bool interface2RadioButtonState = false;
        public int syslogDeviceSender;

        public MainWindow()
        {
            InitializeComponent();
            statisticsHandle = new Statistics(this);
            macTableObj = new MacTable(this);
            sniffer = new Sniffer(this);
            acl = new ACL(this);
            syslog = new Syslog(this);
        }

        private void statistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statisticsHandle.clearTable(1);
        }

        public void macTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StatsResetBtn2_Click(object sender, EventArgs e)
        {
            statisticsHandle.clearTable(2);

        }

        private void StatsResetBtn1_Click(object sender, EventArgs e)
        {
            statisticsHandle.clearTable(1);

        }

        private void StatsResetBtn2_Click_1(object sender, EventArgs e)
        {
            statisticsHandle.clearTable(2);

        }

        private void stopConnection_Click(object sender, EventArgs e)
        {
            Sniffer.stopSniffing();
        }

        private void startConnection_Click(object sender, EventArgs e)
        {
            sniffer.startSniffingMethod();
        }

        private void statistics1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int value = (int)numericUpDown1.Value;

            macTableObj.SetMacRecordTime(value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int value = (int)numericUpDown2.Value;
            sniffer.SetDisconnectTime(value);
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sniffer.startSniffingMethod();
        }

        private void endSniffing_Click(object sender, EventArgs e)
        {
            Sniffer.stopSniffing();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var aclForm = new AclFilterForm(this, 1);
            aclForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            macTableObj.DeleteAllRecords();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(syslogClinetIP.Text))
            {
                syslogClinetIP.Text = "Enter your text here...";
                syslogClinetIP.ForeColor = SystemColors.GrayText; // Change text color to gray
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void syslogClinetIP_Enter(object sender, EventArgs e)
        {
            if (syslogClinetIP.Text == "IP")
            {
                syslogClinetIP.Text = "";
                syslogClinetIP.ForeColor = SystemColors.WindowText;
            }
        }

        private void syslogClinetIP_Leave(object sender, EventArgs e)
        {
            if (syslogClinetIP.Text == "")
            {
                syslogClinetIP.Text = "IP";
                syslogClinetIP.ForeColor = SystemColors.GrayText;
            }
        }

        private void syslogClinetPort_Enter(object sender, EventArgs e)
        {
            if (syslogClinetPort.Text == "Port")
            {
                syslogClinetPort.Text = "";
                syslogClinetPort.ForeColor = SystemColors.WindowText;
            }
        }

        private void syslogClinetPort_Leave(object sender, EventArgs e)
        {
            if (syslogClinetPort.Text == "")
            {
                syslogClinetPort.Text = "Port";
                syslogClinetPort.ForeColor = SystemColors.GrayText;
            }
        }

        private void syslogServerIP_Enter(object sender, EventArgs e)
        {
            if (syslogServerIP.Text == "IP")
            {
                syslogServerIP.Text = "";
                syslogServerIP.ForeColor = SystemColors.WindowText;
            }
        }

        private void syslogServerIP_Leave(object sender, EventArgs e)
        {
            if (syslogServerIP.Text == "")
            {
                syslogServerIP.Text = "IP";
                syslogServerIP.ForeColor = SystemColors.GrayText;
            }
        }

        private void syslogServerPort_Enter(object sender, EventArgs e)
        {
            if (syslogServerPort.Text == "Port")
            {
                syslogServerPort.Text = "";
                syslogServerPort.ForeColor = SystemColors.WindowText;
            }
        }

        private void syslogServerPort_Leave(object sender, EventArgs e)
        {
            if (syslogServerPort.Text == "")
            {
                syslogServerPort.Text = "Port";
                syslogServerPort.ForeColor = SystemColors.GrayText;
            }
        }

        private void modifyAclRecordButton_Click(object sender, EventArgs e)
        {
            int index = ACLtable.CurrentCell.RowIndex;
            AclContainer record = ACL.GetRecord(index);
            var aclForm = new AclFilterForm(this, 2, record.Priority, record.Verdict, record.PortInterface, 
                record.Direction, record.SrcMac, record.DstMac, record.SrcIp, record.DstIp, record.SrcPort,
                record.DstPort, record.EthType, record.ICMPtype, record.Protocol, record);

            aclForm.ShowDialog();
        }

        private void ACLtable_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void startSyslog_Click(object sender, EventArgs e)
        {
            IPAddress clientIp = IPAddress.Parse(syslogClinetIP.Text);
            IPAddress serverIp = IPAddress.Parse(syslogServerIP.Text);
            ushort clientPort = ushort.Parse(syslogClinetPort.Text);
            ushort serverPort = ushort.Parse(syslogServerPort.Text);

            Console.WriteLine($"CLinet ip: {syslogClinetIP.Text}");

            Syslog.StartSyslog(serverIp, clientIp, clientPort, serverPort);
        }

        private void interface1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (interface1RadioButton.Checked) 
            {
                syslogDeviceSender = Sniffer.deviceIndex1;
            }
            else { interface1RadioButtonState = false; }
        }

        private void interface2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (interface2RadioButton.Checked)
            {
                syslogDeviceSender = Sniffer.deviceIndex2;
            }
            else { interface2RadioButtonState = false; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void enableAclCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (enableAclCheckBox.Checked) 
            //{
            //    ACLcontrol.Enabled = true;
            //}
            //else
            //{
            //    ACLcontrol.Enabled = false;
            //}
        }

        private void enableSyslogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSyslogCheckbox.Checked)
            {
                syslogControl.Enabled = true;

            }
            else
            {
                syslogControl.Enabled = false;
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            int index = ACLtable.CurrentCell.RowIndex;
            acl.DeleteRecord(index);
        }
    }
}
