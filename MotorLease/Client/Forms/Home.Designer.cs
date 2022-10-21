
namespace MotorLease.Client.Forms
{
    partial class Home
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
            this.dataGridAllMotors = new System.Windows.Forms.DataGridView();
            this.lblLanding = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnMyBookings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllMotors)).BeginInit();
            this.panelLanding.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAllMotors
            // 
            this.dataGridAllMotors.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAllMotors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllMotors.Location = new System.Drawing.Point(0, 103);
            this.dataGridAllMotors.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridAllMotors.Name = "dataGridAllMotors";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllMotors.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllMotors.RowTemplate.Height = 25;
            this.dataGridAllMotors.Size = new System.Drawing.Size(1067, 420);
            this.dataGridAllMotors.TabIndex = 1;
            this.dataGridAllMotors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllMotors_CellClick);
            // 
            // lblLanding
            // 
            this.lblLanding.BackColor = System.Drawing.Color.SlateGray;
            this.lblLanding.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLanding.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLanding.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLanding.Location = new System.Drawing.Point(0, 0);
            this.lblLanding.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblLanding.Name = "lblLanding";
            this.lblLanding.Size = new System.Drawing.Size(1067, 42);
            this.lblLanding.TabIndex = 2;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLanding.UseWaitCursor = true;
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
            // panelLanding
            // 
            this.panelLanding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLanding.Controls.Add(this.btnManageBookings);
            this.panelLanding.Controls.Add(this.btnManageUsers);
            this.panelLanding.Controls.Add(this.btnMyBookings);
            this.panelLanding.Controls.Add(this.comboBox1);
            this.panelLanding.Controls.Add(this.label1);
            this.panelLanding.Location = new System.Drawing.Point(0, 47);
            this.panelLanding.Name = "panelLanding";
            this.panelLanding.Size = new System.Drawing.Size(1067, 52);
            this.panelLanding.TabIndex = 5;
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageBookings.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageBookings.FlatAppearance.BorderSize = 0;
            this.btnManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageBookings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageBookings.Location = new System.Drawing.Point(319, 21);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(124, 27);
            this.btnManageBookings.TabIndex = 11;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = false;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageUsers.Location = new System.Drawing.Point(189, 21);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(124, 27);
            this.btnManageUsers.TabIndex = 10;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnMyBookings
            // 
            this.btnMyBookings.BackColor = System.Drawing.Color.SlateGray;
            this.btnMyBookings.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnMyBookings.FlatAppearance.BorderSize = 0;
            this.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyBookings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMyBookings.Location = new System.Drawing.Point(3, 21);
            this.btnMyBookings.Name = "btnMyBookings";
            this.btnMyBookings.Size = new System.Drawing.Size(124, 27);
            this.btnMyBookings.TabIndex = 5;
            this.btnMyBookings.Text = "My Bookings";
            this.btnMyBookings.UseVisualStyleBackColor = false;
            this.btnMyBookings.Click += new System.EventHandler(this.LoadMyBookings);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 26);
            this.panel2.TabIndex = 6;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.SlateGray;
            this.linkLabelLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.Location = new System.Drawing.Point(996, 14);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelLogout.TabIndex = 10;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblLanding);
            this.Controls.Add(this.dataGridAllMotors);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotorLease";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllMotors)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.panelLanding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAllMotors;
        public System.Windows.Forms.Label lblLanding;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLanding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Button btnManageUsers;
    }
}