namespace PSIP_software_switch
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ACLcontrol = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.createACLRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.modifyAclRecordButton = new System.Windows.Forms.Button();
            this.ACLtable = new System.Windows.Forms.DataGridView();
            this.syslogControl = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.startSyslog = new System.Windows.Forms.Button();
            this.interface2RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.syslogServerIP = new System.Windows.Forms.TextBox();
            this.syslogServerPort = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.syslogClinetIP = new System.Windows.Forms.TextBox();
            this.syslogClinetPort = new System.Windows.Forms.TextBox();
            this.interface1RadioButton = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.enableSyslogCheckbox = new System.Windows.Forms.CheckBox();
            this.enableAclCheckBox = new System.Windows.Forms.CheckBox();
            this.endSniffing = new System.Windows.Forms.Button();
            this.startSwitch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.interface2ConnectionLabel = new System.Windows.Forms.Label();
            this.interface1ConnectionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.macTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.statistics1 = new System.Windows.Forms.DataGridView();
            this.statistics2 = new System.Windows.Forms.DataGridView();
            this.StatsResetBtn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatsResetBtn1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.resetInterfacesBtn = new System.Windows.Forms.Button();
            this.selectionInterface2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectionInterface1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ACLcontrol.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACLtable)).BeginInit();
            this.syslogControl.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistics1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 792);
            this.panel3.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1065, 780);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ACLcontrol);
            this.panel1.Controls.Add(this.syslogControl);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 751);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ACLcontrol
            // 
            this.ACLcontrol.Controls.Add(this.panel6);
            this.ACLcontrol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ACLcontrol.Location = new System.Drawing.Point(4, 474);
            this.ACLcontrol.Name = "ACLcontrol";
            this.ACLcontrol.Size = new System.Drawing.Size(1052, 271);
            this.ACLcontrol.TabIndex = 17;
            this.ACLcontrol.TabStop = false;
            this.ACLcontrol.Text = "ACL";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.createACLRecord);
            this.panel6.Controls.Add(this.deleteRecord);
            this.panel6.Controls.Add(this.modifyAclRecordButton);
            this.panel6.Controls.Add(this.ACLtable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel6.Location = new System.Drawing.Point(3, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1046, 246);
            this.panel6.TabIndex = 0;
            // 
            // createACLRecord
            // 
            this.createACLRecord.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createACLRecord.Location = new System.Drawing.Point(808, 214);
            this.createACLRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createACLRecord.Name = "createACLRecord";
            this.createACLRecord.Size = new System.Drawing.Size(75, 24);
            this.createACLRecord.TabIndex = 2;
            this.createACLRecord.Text = "Add";
            this.createACLRecord.UseVisualStyleBackColor = true;
            this.createACLRecord.Click += new System.EventHandler(this.button7_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteRecord.Location = new System.Drawing.Point(967, 214);
            this.deleteRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(75, 24);
            this.deleteRecord.TabIndex = 1;
            this.deleteRecord.Text = "Delete";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // modifyAclRecordButton
            // 
            this.modifyAclRecordButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modifyAclRecordButton.Location = new System.Drawing.Point(887, 214);
            this.modifyAclRecordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyAclRecordButton.Name = "modifyAclRecordButton";
            this.modifyAclRecordButton.Size = new System.Drawing.Size(75, 24);
            this.modifyAclRecordButton.TabIndex = 1;
            this.modifyAclRecordButton.Text = "Modify";
            this.modifyAclRecordButton.UseVisualStyleBackColor = true;
            this.modifyAclRecordButton.Click += new System.EventHandler(this.modifyAclRecordButton_Click);
            // 
            // ACLtable
            // 
            this.ACLtable.AllowUserToAddRows = false;
            this.ACLtable.AllowUserToDeleteRows = false;
            this.ACLtable.AllowUserToResizeColumns = false;
            this.ACLtable.AllowUserToResizeRows = false;
            this.ACLtable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ACLtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ACLtable.Location = new System.Drawing.Point(5, 5);
            this.ACLtable.Name = "ACLtable";
            this.ACLtable.ReadOnly = true;
            this.ACLtable.RowHeadersWidth = 51;
            this.ACLtable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ACLtable.Size = new System.Drawing.Size(1037, 204);
            this.ACLtable.TabIndex = 0;
            this.ACLtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ACLtable.SelectionChanged += new System.EventHandler(this.ACLtable_SelectionChanged);
            // 
            // syslogControl
            // 
            this.syslogControl.Controls.Add(this.panel7);
            this.syslogControl.Enabled = false;
            this.syslogControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syslogControl.Location = new System.Drawing.Point(882, 150);
            this.syslogControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogControl.Name = "syslogControl";
            this.syslogControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogControl.Size = new System.Drawing.Size(177, 315);
            this.syslogControl.TabIndex = 16;
            this.syslogControl.TabStop = false;
            this.syslogControl.Text = "Syslog";
            this.syslogControl.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.startSyslog);
            this.panel7.Controls.Add(this.interface2RadioButton);
            this.panel7.Controls.Add(this.groupBox10);
            this.panel7.Controls.Add(this.groupBox9);
            this.panel7.Controls.Add(this.interface1RadioButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 292);
            this.panel7.TabIndex = 0;
            // 
            // startSyslog
            // 
            this.startSyslog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startSyslog.Location = new System.Drawing.Point(7, 238);
            this.startSyslog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startSyslog.Name = "startSyslog";
            this.startSyslog.Size = new System.Drawing.Size(158, 45);
            this.startSyslog.TabIndex = 11;
            this.startSyslog.Text = "Connect";
            this.startSyslog.UseVisualStyleBackColor = true;
            this.startSyslog.Click += new System.EventHandler(this.startSyslog_Click);
            // 
            // interface2RadioButton
            // 
            this.interface2RadioButton.AutoSize = true;
            this.interface2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interface2RadioButton.Location = new System.Drawing.Point(6, 200);
            this.interface2RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interface2RadioButton.Name = "interface2RadioButton";
            this.interface2RadioButton.Size = new System.Drawing.Size(93, 21);
            this.interface2RadioButton.TabIndex = 27;
            this.interface2RadioButton.TabStop = true;
            this.interface2RadioButton.Text = "Interface 2";
            this.interface2RadioButton.UseVisualStyleBackColor = true;
            this.interface2RadioButton.CheckedChanged += new System.EventHandler(this.interface2RadioButton_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.syslogServerIP);
            this.groupBox10.Controls.Add(this.syslogServerPort);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox10.Location = new System.Drawing.Point(6, 91);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(156, 79);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Server";
            // 
            // syslogServerIP
            // 
            this.syslogServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syslogServerIP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.syslogServerIP.Location = new System.Drawing.Point(5, 22);
            this.syslogServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogServerIP.Name = "syslogServerIP";
            this.syslogServerIP.Size = new System.Drawing.Size(146, 24);
            this.syslogServerIP.TabIndex = 22;
            this.syslogServerIP.Text = "IP";
            this.syslogServerIP.Enter += new System.EventHandler(this.syslogServerIP_Enter);
            this.syslogServerIP.Leave += new System.EventHandler(this.syslogServerIP_Leave);
            // 
            // syslogServerPort
            // 
            this.syslogServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syslogServerPort.ForeColor = System.Drawing.SystemColors.GrayText;
            this.syslogServerPort.Location = new System.Drawing.Point(5, 50);
            this.syslogServerPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogServerPort.Name = "syslogServerPort";
            this.syslogServerPort.Size = new System.Drawing.Size(98, 24);
            this.syslogServerPort.TabIndex = 25;
            this.syslogServerPort.Text = "Port";
            this.syslogServerPort.Enter += new System.EventHandler(this.syslogServerPort_Enter);
            this.syslogServerPort.Leave += new System.EventHandler(this.syslogServerPort_Leave);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.syslogClinetIP);
            this.groupBox9.Controls.Add(this.syslogClinetPort);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(156, 79);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Client";
            // 
            // syslogClinetIP
            // 
            this.syslogClinetIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syslogClinetIP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.syslogClinetIP.Location = new System.Drawing.Point(5, 22);
            this.syslogClinetIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogClinetIP.Name = "syslogClinetIP";
            this.syslogClinetIP.Size = new System.Drawing.Size(146, 24);
            this.syslogClinetIP.TabIndex = 22;
            this.syslogClinetIP.Text = "IP";
            this.syslogClinetIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.syslogClinetIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.syslogClinetIP.Enter += new System.EventHandler(this.syslogClinetIP_Enter);
            this.syslogClinetIP.Leave += new System.EventHandler(this.syslogClinetIP_Leave);
            // 
            // syslogClinetPort
            // 
            this.syslogClinetPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syslogClinetPort.ForeColor = System.Drawing.SystemColors.GrayText;
            this.syslogClinetPort.Location = new System.Drawing.Point(5, 50);
            this.syslogClinetPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syslogClinetPort.Name = "syslogClinetPort";
            this.syslogClinetPort.Size = new System.Drawing.Size(98, 24);
            this.syslogClinetPort.TabIndex = 25;
            this.syslogClinetPort.Text = "Port";
            this.syslogClinetPort.Enter += new System.EventHandler(this.syslogClinetPort_Enter);
            this.syslogClinetPort.Leave += new System.EventHandler(this.syslogClinetPort_Leave);
            // 
            // interface1RadioButton
            // 
            this.interface1RadioButton.AutoSize = true;
            this.interface1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interface1RadioButton.Location = new System.Drawing.Point(6, 175);
            this.interface1RadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interface1RadioButton.Name = "interface1RadioButton";
            this.interface1RadioButton.Size = new System.Drawing.Size(93, 21);
            this.interface1RadioButton.TabIndex = 26;
            this.interface1RadioButton.TabStop = true;
            this.interface1RadioButton.Text = "Interface 1";
            this.interface1RadioButton.UseVisualStyleBackColor = true;
            this.interface1RadioButton.CheckedChanged += new System.EventHandler(this.interface1RadioButton_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Location = new System.Drawing.Point(1421, 284);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 24);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "PORT";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.enableSyslogCheckbox);
            this.groupBox6.Controls.Add(this.enableAclCheckBox);
            this.groupBox6.Controls.Add(this.endSniffing);
            this.groupBox6.Controls.Add(this.startSwitch);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(882, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(174, 145);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Switch control";
            // 
            // enableSyslogCheckbox
            // 
            this.enableSyslogCheckbox.AutoSize = true;
            this.enableSyslogCheckbox.Location = new System.Drawing.Point(5, 114);
            this.enableSyslogCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enableSyslogCheckbox.Name = "enableSyslogCheckbox";
            this.enableSyslogCheckbox.Size = new System.Drawing.Size(75, 24);
            this.enableSyslogCheckbox.TabIndex = 12;
            this.enableSyslogCheckbox.Text = "Syslog";
            this.enableSyslogCheckbox.UseVisualStyleBackColor = true;
            this.enableSyslogCheckbox.CheckedChanged += new System.EventHandler(this.enableSyslogCheckbox_CheckedChanged);
            // 
            // enableAclCheckBox
            // 
            this.enableAclCheckBox.AutoSize = true;
            this.enableAclCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enableAclCheckBox.Location = new System.Drawing.Point(5, 85);
            this.enableAclCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enableAclCheckBox.Name = "enableAclCheckBox";
            this.enableAclCheckBox.Size = new System.Drawing.Size(55, 22);
            this.enableAclCheckBox.TabIndex = 11;
            this.enableAclCheckBox.Text = "ACL";
            this.enableAclCheckBox.UseVisualStyleBackColor = true;
            this.enableAclCheckBox.CheckedChanged += new System.EventHandler(this.enableAclCheckBox_CheckedChanged);
            // 
            // endSniffing
            // 
            this.endSniffing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endSniffing.Location = new System.Drawing.Point(5, 55);
            this.endSniffing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endSniffing.Name = "endSniffing";
            this.endSniffing.Size = new System.Drawing.Size(167, 26);
            this.endSniffing.TabIndex = 10;
            this.endSniffing.Text = "DISABLE";
            this.endSniffing.UseVisualStyleBackColor = true;
            this.endSniffing.Click += new System.EventHandler(this.endSniffing_Click);
            // 
            // startSwitch
            // 
            this.startSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startSwitch.Location = new System.Drawing.Point(5, 25);
            this.startSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startSwitch.Name = "startSwitch";
            this.startSwitch.Size = new System.Drawing.Size(164, 26);
            this.startSwitch.TabIndex = 9;
            this.startSwitch.Text = "ENABLE";
            this.startSwitch.UseVisualStyleBackColor = true;
            this.startSwitch.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(1421, 257);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 24);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "PORT";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.interface2ConnectionLabel);
            this.groupBox5.Controls.Add(this.interface1ConnectionLabel);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(593, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(277, 145);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interface status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(5, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Time until disconnected";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown2.Location = new System.Drawing.Point(168, 100);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // interface2ConnectionLabel
            // 
            this.interface2ConnectionLabel.AutoSize = true;
            this.interface2ConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interface2ConnectionLabel.ForeColor = System.Drawing.Color.Red;
            this.interface2ConnectionLabel.Location = new System.Drawing.Point(165, 63);
            this.interface2ConnectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interface2ConnectionLabel.Name = "interface2ConnectionLabel";
            this.interface2ConnectionLabel.Size = new System.Drawing.Size(111, 18);
            this.interface2ConnectionLabel.TabIndex = 18;
            this.interface2ConnectionLabel.Text = "Disconnected";
            // 
            // interface1ConnectionLabel
            // 
            this.interface1ConnectionLabel.AutoSize = true;
            this.interface1ConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interface1ConnectionLabel.ForeColor = System.Drawing.Color.Red;
            this.interface1ConnectionLabel.Location = new System.Drawing.Point(165, 26);
            this.interface1ConnectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interface1ConnectionLabel.Name = "interface1ConnectionLabel";
            this.interface1ConnectionLabel.Size = new System.Drawing.Size(111, 18);
            this.interface1ConnectionLabel.TabIndex = 17;
            this.interface1ConnectionLabel.Text = "Disconnected";
            this.interface1ConnectionLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Interface 1 status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Interface 0 status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(593, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 318);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mac Table";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Controls.Add(this.macTable);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel5.Location = new System.Drawing.Point(3, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 293);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(2, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Timeout:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(69, 258);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // macTable
            // 
            this.macTable.AllowUserToAddRows = false;
            this.macTable.AllowUserToDeleteRows = false;
            this.macTable.AllowUserToResizeColumns = false;
            this.macTable.AllowUserToResizeRows = false;
            this.macTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.macTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.macTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.macTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.macTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.macTable.Enabled = false;
            this.macTable.Location = new System.Drawing.Point(5, 27);
            this.macTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.macTable.Name = "macTable";
            this.macTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.macTable.RowTemplate.Height = 24;
            this.macTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.macTable.Size = new System.Drawing.Size(265, 225);
            this.macTable.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(141, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset Mac Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(7, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 318);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.statistics1);
            this.panel4.Controls.Add(this.statistics2);
            this.panel4.Controls.Add(this.StatsResetBtn2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.StatsResetBtn1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel4.Location = new System.Drawing.Point(3, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 293);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(288, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interface 1";
            // 
            // statistics1
            // 
            this.statistics1.AllowUserToResizeRows = false;
            this.statistics1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statistics1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.statistics1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statistics1.DefaultCellStyle = dataGridViewCellStyle2;
            this.statistics1.Enabled = false;
            this.statistics1.Location = new System.Drawing.Point(5, 27);
            this.statistics1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistics1.Name = "statistics1";
            this.statistics1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.statistics1.RowTemplate.Height = 24;
            this.statistics1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statistics1.Size = new System.Drawing.Size(265, 225);
            this.statistics1.TabIndex = 0;
            this.statistics1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statistics1_CellContentClick);
            // 
            // statistics2
            // 
            this.statistics2.AllowUserToResizeColumns = false;
            this.statistics2.AllowUserToResizeRows = false;
            this.statistics2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statistics2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.statistics2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statistics2.DefaultCellStyle = dataGridViewCellStyle3;
            this.statistics2.Enabled = false;
            this.statistics2.Location = new System.Drawing.Point(291, 27);
            this.statistics2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistics2.Name = "statistics2";
            this.statistics2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.statistics2.RowTemplate.Height = 24;
            this.statistics2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statistics2.Size = new System.Drawing.Size(265, 225);
            this.statistics2.TabIndex = 1;
            // 
            // StatsResetBtn2
            // 
            this.StatsResetBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatsResetBtn2.Location = new System.Drawing.Point(364, 256);
            this.StatsResetBtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatsResetBtn2.Name = "StatsResetBtn2";
            this.StatsResetBtn2.Size = new System.Drawing.Size(113, 26);
            this.StatsResetBtn2.TabIndex = 8;
            this.StatsResetBtn2.Text = "Reset Statistics";
            this.StatsResetBtn2.UseVisualStyleBackColor = true;
            this.StatsResetBtn2.Click += new System.EventHandler(this.StatsResetBtn2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interface 0";
            // 
            // StatsResetBtn1
            // 
            this.StatsResetBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatsResetBtn1.Location = new System.Drawing.Point(78, 256);
            this.StatsResetBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatsResetBtn1.Name = "StatsResetBtn1";
            this.StatsResetBtn1.Size = new System.Drawing.Size(114, 26);
            this.StatsResetBtn1.TabIndex = 7;
            this.StatsResetBtn1.Text = "Reset Statistics";
            this.StatsResetBtn1.UseVisualStyleBackColor = true;
            this.StatsResetBtn1.Click += new System.EventHandler(this.StatsResetBtn1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(572, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface control";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.resetInterfacesBtn);
            this.panel2.Controls.Add(this.selectionInterface2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.selectionInterface1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(2, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 122);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Set Automatically";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // resetInterfacesBtn
            // 
            this.resetInterfacesBtn.Location = new System.Drawing.Point(6, 67);
            this.resetInterfacesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetInterfacesBtn.Name = "resetInterfacesBtn";
            this.resetInterfacesBtn.Size = new System.Drawing.Size(106, 30);
            this.resetInterfacesBtn.TabIndex = 7;
            this.resetInterfacesBtn.Text = "Reset Interfaces";
            this.resetInterfacesBtn.UseVisualStyleBackColor = true;
            // 
            // selectionInterface2
            // 
            this.selectionInterface2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionInterface2.FormattingEnabled = true;
            this.selectionInterface2.Location = new System.Drawing.Point(294, 28);
            this.selectionInterface2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionInterface2.Name = "selectionInterface2";
            this.selectionInterface2.Size = new System.Drawing.Size(265, 24);
            this.selectionInterface2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(291, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interface 1";
            // 
            // selectionInterface1
            // 
            this.selectionInterface1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionInterface1.FormattingEnabled = true;
            this.selectionInterface1.Location = new System.Drawing.Point(5, 28);
            this.selectionInterface1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionInterface1.Name = "selectionInterface1";
            this.selectionInterface1.Size = new System.Drawing.Size(265, 24);
            this.selectionInterface1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interface 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1086, 792);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Software Switch";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ACLcontrol.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ACLtable)).EndInit();
            this.syslogControl.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistics1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox selectionInterface2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox selectionInterface1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView macTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView statistics1;
        public System.Windows.Forms.DataGridView statistics2;
        private System.Windows.Forms.Button StatsResetBtn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StatsResetBtn1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        public System.Windows.Forms.Label interface2ConnectionLabel;
        public System.Windows.Forms.Label interface1ConnectionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button startSwitch;
        private System.Windows.Forms.Button endSniffing;
        public System.Windows.Forms.GroupBox syslogControl;
        public System.Windows.Forms.TextBox syslogClinetIP;
        public System.Windows.Forms.RadioButton interface1RadioButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.RadioButton interface2RadioButton;
        private System.Windows.Forms.GroupBox ACLcontrol;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.TextBox syslogServerIP;
        public System.Windows.Forms.TextBox syslogServerPort;
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.TextBox syslogClinetPort;
        private System.Windows.Forms.Button startSyslog;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button modifyAclRecordButton;
        private System.Windows.Forms.Button createACLRecord;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView ACLtable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.CheckBox enableSyslogCheckbox;
        public System.Windows.Forms.CheckBox enableAclCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button resetInterfacesBtn;
    }
}

