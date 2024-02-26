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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statistics1 = new System.Windows.Forms.DataGridView();
            this.statistics2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectionInterface1 = new System.Windows.Forms.ComboBox();
            this.selectionInterface2 = new System.Windows.Forms.ComboBox();
            this.StatsResetBtn1 = new System.Windows.Forms.Button();
            this.StatsResetBtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MacCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statistics1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statistics1
            // 
            this.statistics1.AllowUserToResizeRows = false;
            this.statistics1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statistics1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.statistics1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statistics1.DefaultCellStyle = dataGridViewCellStyle11;
            this.statistics1.Location = new System.Drawing.Point(15, 62);
            this.statistics1.Name = "statistics1";
            this.statistics1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.statistics1.RowTemplate.Height = 24;
            this.statistics1.Size = new System.Drawing.Size(345, 275);
            this.statistics1.TabIndex = 0;
            this.statistics1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statistics_CellContentClick);
            // 
            // statistics2
            // 
            this.statistics2.AllowUserToResizeRows = false;
            this.statistics2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statistics2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.statistics2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statistics2.DefaultCellStyle = dataGridViewCellStyle12;
            this.statistics2.Location = new System.Drawing.Point(379, 62);
            this.statistics2.Name = "statistics2";
            this.statistics2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.statistics2.RowTemplate.Height = 24;
            this.statistics2.Size = new System.Drawing.Size(345, 275);
            this.statistics2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interface 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interface 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selectionInterface1
            // 
            this.selectionInterface1.FormattingEnabled = true;
            this.selectionInterface1.Location = new System.Drawing.Point(66, 32);
            this.selectionInterface1.Name = "selectionInterface1";
            this.selectionInterface1.Size = new System.Drawing.Size(235, 24);
            this.selectionInterface1.TabIndex = 4;
            // 
            // selectionInterface2
            // 
            this.selectionInterface2.FormattingEnabled = true;
            this.selectionInterface2.Location = new System.Drawing.Point(436, 32);
            this.selectionInterface2.Name = "selectionInterface2";
            this.selectionInterface2.Size = new System.Drawing.Size(235, 24);
            this.selectionInterface2.TabIndex = 6;
            // 
            // StatsResetBtn1
            // 
            this.StatsResetBtn1.Location = new System.Drawing.Point(123, 343);
            this.StatsResetBtn1.Name = "StatsResetBtn1";
            this.StatsResetBtn1.Size = new System.Drawing.Size(117, 32);
            this.StatsResetBtn1.TabIndex = 7;
            this.StatsResetBtn1.Text = "Reset Statistics";
            this.StatsResetBtn1.UseVisualStyleBackColor = true;
            this.StatsResetBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatsResetBtn2
            // 
            this.StatsResetBtn2.Location = new System.Drawing.Point(488, 343);
            this.StatsResetBtn2.Name = "StatsResetBtn2";
            this.StatsResetBtn2.Size = new System.Drawing.Size(117, 32);
            this.StatsResetBtn2.TabIndex = 8;
            this.StatsResetBtn2.Text = "Reset Statistics";
            this.StatsResetBtn2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MacCol,
            this.PortCol,
            this.ExpirationCol});
            this.dataGridView1.Location = new System.Drawing.Point(743, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(424, 275);
            this.dataGridView1.TabIndex = 9;
            // 
            // MacCol
            // 
            this.MacCol.HeaderText = "MAC";
            this.MacCol.MinimumWidth = 6;
            this.MacCol.Name = "MacCol";
            this.MacCol.Width = 125;
            // 
            // PortCol
            // 
            this.PortCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PortCol.HeaderText = "PORT";
            this.PortCol.MinimumWidth = 6;
            this.PortCol.Name = "PortCol";
            this.PortCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PortCol.Width = 74;
            // 
            // ExpirationCol
            // 
            this.ExpirationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ExpirationCol.HeaderText = "EXPIRATION";
            this.ExpirationCol.MinimumWidth = 6;
            this.ExpirationCol.Name = "ExpirationCol";
            this.ExpirationCol.Width = 116;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatsResetBtn2);
            this.Controls.Add(this.StatsResetBtn1);
            this.Controls.Add(this.selectionInterface2);
            this.Controls.Add(this.selectionInterface1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statistics2);
            this.Controls.Add(this.statistics1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statistics1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView statistics1;
        public System.Windows.Forms.DataGridView statistics2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox selectionInterface1;
        public System.Windows.Forms.ComboBox selectionInterface2;
        private System.Windows.Forms.Button StatsResetBtn1;
        private System.Windows.Forms.Button StatsResetBtn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationCol;
    }
}

