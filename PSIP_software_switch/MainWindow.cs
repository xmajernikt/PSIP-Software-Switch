using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSIP_software_switch
{
    public partial class MainWindow : Form
    {
        private Statistics statisticsHandle;
        private Sniffer sniffer;
        private static MacTable macTableObj;
        public MainWindow()
        {
            InitializeComponent();
            statisticsHandle = new Statistics(this);
            macTableObj = new MacTable(this);
            sniffer = new Sniffer(this);
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
            var aclForm = new AclFilterForm();
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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter your text here...";
                textBox1.ForeColor = SystemColors.GrayText; // Change text color to gray
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "IP")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // Change text color to default
            }
        }
    }
}
