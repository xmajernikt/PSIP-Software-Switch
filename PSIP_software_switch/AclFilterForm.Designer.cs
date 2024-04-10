namespace PSIP_software_switch
{
    partial class AclFilterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBoxEthType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDstPort = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSrcPort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxICMP = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dstMacTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srcMacTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outCheckBox = new System.Windows.Forms.CheckBox();
            this.InCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dstIPTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.srcIPTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.denyRadioButton = new System.Windows.Forms.RadioButton();
            this.allowRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.addAclRecord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDstPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSrcPort)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACL settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Controls.Add(this.groupBox10);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.addAclRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 405);
            this.panel1.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBoxEthType);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Location = new System.Drawing.Point(229, 225);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 68);
            this.groupBox11.TabIndex = 42;
            this.groupBox11.TabStop = false;
            // 
            // comboBoxEthType
            // 
            this.comboBoxEthType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxEthType.FormattingEnabled = true;
            this.comboBoxEthType.Items.AddRange(new object[] {
            "ANY",
            "IPv4",
            "ARP"});
            this.comboBoxEthType.Location = new System.Drawing.Point(87, 22);
            this.comboBoxEthType.Name = "comboBoxEthType";
            this.comboBoxEthType.Size = new System.Drawing.Size(105, 24);
            this.comboBoxEthType.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "EtherType: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBoxProtocol);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Location = new System.Drawing.Point(229, 299);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 68);
            this.groupBox10.TabIndex = 42;
            this.groupBox10.TabStop = false;
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Items.AddRange(new object[] {
            "ANY",
            "ICMP",
            "TCP",
            "UDP"});
            this.comboBoxProtocol.Location = new System.Drawing.Point(87, 19);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(105, 24);
            this.comboBoxProtocol.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Protocol:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numericUpDownDstPort);
            this.groupBox9.Controls.Add(this.numericUpDownSrcPort);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Location = new System.Drawing.Point(3, 225);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 68);
            this.groupBox9.TabIndex = 42;
            this.groupBox9.TabStop = false;
            // 
            // numericUpDownDstPort
            // 
            this.numericUpDownDstPort.Location = new System.Drawing.Point(84, 40);
            this.numericUpDownDstPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDstPort.Name = "numericUpDownDstPort";
            this.numericUpDownDstPort.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownDstPort.TabIndex = 31;
            // 
            // numericUpDownSrcPort
            // 
            this.numericUpDownSrcPort.Location = new System.Drawing.Point(84, 11);
            this.numericUpDownSrcPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSrcPort.Name = "numericUpDownSrcPort";
            this.numericUpDownSrcPort.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownSrcPort.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Src. port:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Dst. port:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxICMP);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(3, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 68);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            // 
            // comboBoxICMP
            // 
            this.comboBoxICMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxICMP.FormattingEnabled = true;
            this.comboBoxICMP.Items.AddRange(new object[] {
            "ANY",
            "EchoReply",
            "EchoRequest"});
            this.comboBoxICMP.Location = new System.Drawing.Point(84, 22);
            this.comboBoxICMP.Name = "comboBoxICMP";
            this.comboBoxICMP.Size = new System.Drawing.Size(105, 24);
            this.comboBoxICMP.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "ICMP type:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dstMacTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.srcMacTextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(3, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 68);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // dstMacTextBox
            // 
            this.dstMacTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dstMacTextBox.ForeColor = System.Drawing.Color.Black;
            this.dstMacTextBox.Location = new System.Drawing.Point(84, 41);
            this.dstMacTextBox.Name = "dstMacTextBox";
            this.dstMacTextBox.Size = new System.Drawing.Size(105, 21);
            this.dstMacTextBox.TabIndex = 20;
            this.dstMacTextBox.Text = "Any";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dst. MAC: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcMacTextBox
            // 
            this.srcMacTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srcMacTextBox.ForeColor = System.Drawing.Color.Black;
            this.srcMacTextBox.Location = new System.Drawing.Point(84, 12);
            this.srcMacTextBox.Name = "srcMacTextBox";
            this.srcMacTextBox.Size = new System.Drawing.Size(105, 21);
            this.srcMacTextBox.TabIndex = 19;
            this.srcMacTextBox.Text = "Any";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Src.  MAC:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxPort);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(3, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "ANY",
            "Interface 1",
            "Interface 2"});
            this.comboBoxPort.Location = new System.Drawing.Point(84, 22);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(105, 24);
            this.comboBoxPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outCheckBox);
            this.groupBox2.Controls.Add(this.InCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(229, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // outCheckBox
            // 
            this.outCheckBox.AutoSize = true;
            this.outCheckBox.Location = new System.Drawing.Point(87, 45);
            this.outCheckBox.Name = "outCheckBox";
            this.outCheckBox.Size = new System.Drawing.Size(57, 21);
            this.outCheckBox.TabIndex = 44;
            this.outCheckBox.Text = "OUT";
            this.outCheckBox.UseVisualStyleBackColor = true;
            // 
            // InCheckBox
            // 
            this.InCheckBox.AutoSize = true;
            this.InCheckBox.Location = new System.Drawing.Point(87, 18);
            this.InCheckBox.Name = "InCheckBox";
            this.InCheckBox.Size = new System.Drawing.Size(40, 21);
            this.InCheckBox.TabIndex = 43;
            this.InCheckBox.Text = "IN";
            this.InCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Direction:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dstIPTextBox);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.srcIPTextBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(229, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 68);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            // 
            // dstIPTextBox
            // 
            this.dstIPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dstIPTextBox.ForeColor = System.Drawing.Color.Black;
            this.dstIPTextBox.Location = new System.Drawing.Point(87, 41);
            this.dstIPTextBox.Name = "dstIPTextBox";
            this.dstIPTextBox.Size = new System.Drawing.Size(105, 21);
            this.dstIPTextBox.TabIndex = 25;
            this.dstIPTextBox.Text = "Any";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Dst. IP: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcIPTextBox
            // 
            this.srcIPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srcIPTextBox.ForeColor = System.Drawing.Color.Black;
            this.srcIPTextBox.Location = new System.Drawing.Point(87, 12);
            this.srcIPTextBox.Name = "srcIPTextBox";
            this.srcIPTextBox.Size = new System.Drawing.Size(105, 21);
            this.srcIPTextBox.TabIndex = 23;
            this.srcIPTextBox.Text = "Any";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Src. IP: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.denyRadioButton);
            this.groupBox8.Controls.Add(this.allowRadioButton);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(229, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 68);
            this.groupBox8.TabIndex = 40;
            this.groupBox8.TabStop = false;
            // 
            // denyRadioButton
            // 
            this.denyRadioButton.AutoSize = true;
            this.denyRadioButton.Location = new System.Drawing.Point(87, 43);
            this.denyRadioButton.Name = "denyRadioButton";
            this.denyRadioButton.Size = new System.Drawing.Size(59, 21);
            this.denyRadioButton.TabIndex = 5;
            this.denyRadioButton.TabStop = true;
            this.denyRadioButton.Text = "Deny";
            this.denyRadioButton.UseVisualStyleBackColor = true;
            // 
            // allowRadioButton
            // 
            this.allowRadioButton.AutoSize = true;
            this.allowRadioButton.Location = new System.Drawing.Point(87, 21);
            this.allowRadioButton.Name = "allowRadioButton";
            this.allowRadioButton.Size = new System.Drawing.Size(58, 21);
            this.allowRadioButton.TabIndex = 4;
            this.allowRadioButton.TabStop = true;
            this.allowRadioButton.Text = "Allow";
            this.allowRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Verdict: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownPriority);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 68);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            // 
            // numericUpDownPriority
            // 
            this.numericUpDownPriority.Location = new System.Drawing.Point(84, 29);
            this.numericUpDownPriority.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPriority.Name = "numericUpDownPriority";
            this.numericUpDownPriority.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownPriority.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Priority: ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAclRecord
            // 
            this.addAclRecord.Location = new System.Drawing.Point(346, 372);
            this.addAclRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAclRecord.Name = "addAclRecord";
            this.addAclRecord.Size = new System.Drawing.Size(83, 27);
            this.addAclRecord.TabIndex = 32;
            this.addAclRecord.Text = "Add";
            this.addAclRecord.UseVisualStyleBackColor = true;
            this.addAclRecord.Click += new System.EventHandler(this.addAclRecord_Click);
            // 
            // AclFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 428);
            this.Controls.Add(this.groupBox1);
            this.Name = "AclFilterForm";
            this.Text = "ACL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDstPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSrcPort)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addAclRecord;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox outCheckBox;
        private System.Windows.Forms.CheckBox InCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton denyRadioButton;
        private System.Windows.Forms.RadioButton allowRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPriority;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox srcMacTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dstMacTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboBoxEthType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dstIPTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox srcIPTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownDstPort;
        private System.Windows.Forms.NumericUpDown numericUpDownSrcPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxICMP;
        private System.Windows.Forms.Label label13;
    }
}