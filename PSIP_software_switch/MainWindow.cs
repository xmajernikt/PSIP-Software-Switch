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
        public MainWindow()
        {
            InitializeComponent();
            statisticsHandle = new Statistics(this);
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

        }
    }
}
