namespace MotorLease.Client.Forms
{
    partial class ManageCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblManageCars = new System.Windows.Forms.Label();
            this.linkLabelManageCarsBack = new System.Windows.Forms.LinkLabel();
            this.linkLabelManageCarsLogout = new System.Windows.Forms.LinkLabel();
            this.panelManageCars = new System.Windows.Forms.Panel();
            this.dateTimePickerManageCarsTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerManageCarsFrom = new System.Windows.Forms.DateTimePicker();
            this.btnManageCarsFilter = new System.Windows.Forms.Button();
            this.labelManageCarsTo = new System.Windows.Forms.Label();
            this.labelManageCarsFrom = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridManageCars = new System.Windows.Forms.DataGridView();
            this.panelFooterManageCars = new System.Windows.Forms.Panel();
            this.panelManageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridManageCars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageCars
            // 
            this.lblManageCars.BackColor = System.Drawing.Color.SteelBlue;
            this.lblManageCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblManageCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblManageCars.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblManageCars.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblManageCars.Location = new System.Drawing.Point(0, 0);
            this.lblManageCars.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblManageCars.Name = "lblManageCars";
            this.lblManageCars.Size = new System.Drawing.Size(909, 42);
            this.lblManageCars.TabIndex = 3;
            this.lblManageCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblManageCars.UseWaitCursor = true;
            // 
            // linkLabelManageCarsBack
            // 
            this.linkLabelManageCarsBack.AutoSize = true;
            this.linkLabelManageCarsBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageCarsBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageCarsBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageCarsBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelManageCarsBack.Location = new System.Drawing.Point(3, 17);
            this.linkLabelManageCarsBack.Name = "linkLabelManageCarsBack";
            this.linkLabelManageCarsBack.Size = new System.Drawing.Size(47, 13);
            this.linkLabelManageCarsBack.TabIndex = 14;
            this.linkLabelManageCarsBack.TabStop = true;
            this.linkLabelManageCarsBack.Text = "Go Back";
            this.linkLabelManageCarsBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // linkLabelManageCarsLogout
            // 
            this.linkLabelManageCarsLogout.AutoSize = true;
            this.linkLabelManageCarsLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageCarsLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageCarsLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageCarsLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageCarsLogout.Location = new System.Drawing.Point(846, 11);
            this.linkLabelManageCarsLogout.Name = "linkLabelManageCarsLogout";
            this.linkLabelManageCarsLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelManageCarsLogout.TabIndex = 15;
            this.linkLabelManageCarsLogout.TabStop = true;
            this.linkLabelManageCarsLogout.Text = "Logout";
            this.linkLabelManageCarsLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // panelManageCars
            // 
            this.panelManageCars.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelManageCars.Controls.Add(this.dateTimePickerManageCarsTo);
            this.panelManageCars.Controls.Add(this.dateTimePickerManageCarsFrom);
            this.panelManageCars.Controls.Add(this.btnManageCarsFilter);
            this.panelManageCars.Controls.Add(this.labelManageCarsTo);
            this.panelManageCars.Controls.Add(this.labelManageCarsFrom);
            this.panelManageCars.Controls.Add(this.comboBox1);
            this.panelManageCars.Controls.Add(this.label1);
            this.panelManageCars.Location = new System.Drawing.Point(0, 47);
            this.panelManageCars.Name = "panelManageCars";
            this.panelManageCars.Size = new System.Drawing.Size(908, 52);
            this.panelManageCars.TabIndex = 16;
            // 
            // dateTimePickerManageCarsTo
            // 
            this.dateTimePickerManageCarsTo.Location = new System.Drawing.Point(209, 26);
            this.dateTimePickerManageCarsTo.Name = "dateTimePickerManageCarsTo";
            this.dateTimePickerManageCarsTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageCarsTo.TabIndex = 20;
            // 
            // dateTimePickerManageCarsFrom
            // 
            this.dateTimePickerManageCarsFrom.Location = new System.Drawing.Point(3, 26);
            this.dateTimePickerManageCarsFrom.Name = "dateTimePickerManageCarsFrom";
            this.dateTimePickerManageCarsFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageCarsFrom.TabIndex = 19;
            // 
            // btnManageCarsFilter
            // 
            this.btnManageCarsFilter.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageCarsFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageCarsFilter.FlatAppearance.BorderSize = 0;
            this.btnManageCarsFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCarsFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageCarsFilter.Location = new System.Drawing.Point(417, 27);
            this.btnManageCarsFilter.Name = "btnManageCarsFilter";
            this.btnManageCarsFilter.Size = new System.Drawing.Size(54, 22);
            this.btnManageCarsFilter.TabIndex = 18;
            this.btnManageCarsFilter.Text = "Filter";
            this.btnManageCarsFilter.UseVisualStyleBackColor = false;
            this.btnManageCarsFilter.Click += new System.EventHandler(this.Filter);
            // 
            // labelManageCarsTo
            // 
            this.labelManageCarsTo.AutoSize = true;
            this.labelManageCarsTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCarsTo.Location = new System.Drawing.Point(209, 5);
            this.labelManageCarsTo.Name = "labelManageCarsTo";
            this.labelManageCarsTo.Size = new System.Drawing.Size(29, 19);
            this.labelManageCarsTo.TabIndex = 17;
            this.labelManageCarsTo.Text = "To:";
            // 
            // labelManageCarsFrom
            // 
            this.labelManageCarsFrom.AutoSize = true;
            this.labelManageCarsFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCarsFrom.Location = new System.Drawing.Point(3, 5);
            this.labelManageCarsFrom.Name = "labelManageCarsFrom";
            this.labelManageCarsFrom.Size = new System.Drawing.Size(48, 19);
            this.labelManageCarsFrom.TabIndex = 16;
            this.labelManageCarsFrom.Text = "From:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Type",
            "Make",
            "Price",
            "Availability"});
            this.comboBox1.Location = new System.Drawing.Point(943, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1004, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridManageCars
            // 
            this.dataGridManageCars.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridManageCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridManageCars.Location = new System.Drawing.Point(3, 103);
            this.dataGridManageCars.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridManageCars.Name = "dataGridManageCars";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridManageCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridManageCars.RowTemplate.Height = 25;
            this.dataGridManageCars.Size = new System.Drawing.Size(905, 332);
            this.dataGridManageCars.TabIndex = 17;
            this.dataGridManageCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridManageCars_CellClick);
            // 
            // panelFooterManageCars
            // 
            this.panelFooterManageCars.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFooterManageCars.Location = new System.Drawing.Point(3, 436);
            this.panelFooterManageCars.Name = "panelFooterManageCars";
            this.panelFooterManageCars.Size = new System.Drawing.Size(905, 26);
            this.panelFooterManageCars.TabIndex = 18;
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 463);
            this.Controls.Add(this.panelFooterManageCars);
            this.Controls.Add(this.dataGridManageCars);
            this.Controls.Add(this.panelManageCars);
            this.Controls.Add(this.linkLabelManageCarsLogout);
            this.Controls.Add(this.linkLabelManageCarsBack);
            this.Controls.Add(this.lblManageCars);
            this.Name = "ManageCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCars";
            this.Load += new System.EventHandler(this.ManageCars_Load);
            this.panelManageCars.ResumeLayout(false);
            this.panelManageCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridManageCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblManageCars;
        private System.Windows.Forms.LinkLabel linkLabelManageCarsBack;
        private System.Windows.Forms.LinkLabel linkLabelManageCarsLogout;
        private System.Windows.Forms.Panel panelManageCars;
        private System.Windows.Forms.Button btnManageCarsFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridManageCars;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageCarsTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageCarsFrom;
        private System.Windows.Forms.Label labelManageCarsTo;
        private System.Windows.Forms.Label labelManageCarsFrom;
        private System.Windows.Forms.Panel panelFooterManageCars;
    }
}