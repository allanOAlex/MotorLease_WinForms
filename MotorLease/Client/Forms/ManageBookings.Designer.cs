
namespace MotorLease.Client.Forms
{
    partial class ManageBookings
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
            System.Windows.Forms.Label lblWelcome;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.dataGridAllBookings = new System.Windows.Forms.DataGridView();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.lblLanding = new System.Windows.Forms.Label();
            lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBookings)).BeginInit();
            this.panelLanding.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = System.Drawing.Color.SlateGray;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLight;
            lblWelcome.Location = new System.Drawing.Point(12, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(126, 19);
            lblWelcome.TabIndex = 15;
            lblWelcome.Text = "Welcome Message";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.SlateGray;
            this.linkLabelLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.Location = new System.Drawing.Point(996, 12);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelLogout.TabIndex = 16;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            // 
            // dataGridAllBookings
            // 
            this.dataGridAllBookings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllBookings.Location = new System.Drawing.Point(0, 101);
            this.dataGridAllBookings.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridAllBookings.Name = "dataGridAllBookings";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllBookings.RowTemplate.Height = 25;
            this.dataGridAllBookings.Size = new System.Drawing.Size(1067, 420);
            this.dataGridAllBookings.TabIndex = 11;
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreateBooking.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateBooking.FlatAppearance.BorderSize = 0;
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateBooking.Location = new System.Drawing.Point(3, 21);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(124, 27);
            this.btnCreateBooking.TabIndex = 5;
            this.btnCreateBooking.Text = "Create New";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 26);
            this.panel2.TabIndex = 14;
            // 
            // panelLanding
            // 
            this.panelLanding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLanding.Controls.Add(this.btnCreateBooking);
            this.panelLanding.Location = new System.Drawing.Point(0, 45);
            this.panelLanding.Name = "panelLanding";
            this.panelLanding.Size = new System.Drawing.Size(1067, 52);
            this.panelLanding.TabIndex = 13;
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
            this.lblLanding.Size = new System.Drawing.Size(1069, 42);
            this.lblLanding.TabIndex = 12;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLanding.UseWaitCursor = true;
            // 
            // ManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 546);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(lblWelcome);
            this.Controls.Add(this.dataGridAllBookings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblLanding);
            this.Name = "ManageBookings";
            this.Text = "ManageBookings";
            this.Load += new System.EventHandler(this.ManageBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBookings)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.DataGridView dataGridAllBookings;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLanding;
        public System.Windows.Forms.Label lblLanding;
    }
}