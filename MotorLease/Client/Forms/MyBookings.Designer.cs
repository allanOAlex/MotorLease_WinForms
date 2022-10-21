﻿
namespace MotorLease.Client.Forms
{
    partial class MyBookings
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
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.lblFilterTo = new System.Windows.Forms.Label();
            this.lblFilterFrom = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblLanding = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserBookingsSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.panelLanding.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(2, 101);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowTemplate.Height = 25;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1075, 404);
            this.dataGridViewBookings.TabIndex = 8;
            this.dataGridViewBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookings_CellClick);
            // 
            // panelLanding
            // 
            this.panelLanding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLanding.Controls.Add(this.btnUserBookingsSearch);
            this.panelLanding.Controls.Add(this.lblFilterTo);
            this.panelLanding.Controls.Add(this.lblFilterFrom);
            this.panelLanding.Controls.Add(this.dateTimePicker2);
            this.panelLanding.Controls.Add(this.dateTimePicker1);
            this.panelLanding.Location = new System.Drawing.Point(2, 47);
            this.panelLanding.Name = "panelLanding";
            this.panelLanding.Size = new System.Drawing.Size(1075, 52);
            this.panelLanding.TabIndex = 10;
            // 
            // lblFilterTo
            // 
            this.lblFilterTo.AutoSize = true;
            this.lblFilterTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterTo.Location = new System.Drawing.Point(239, 3);
            this.lblFilterTo.Name = "lblFilterTo";
            this.lblFilterTo.Size = new System.Drawing.Size(23, 19);
            this.lblFilterTo.TabIndex = 9;
            this.lblFilterTo.Text = "To";
            this.lblFilterTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterFrom
            // 
            this.lblFilterFrom.AutoSize = true;
            this.lblFilterFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterFrom.Location = new System.Drawing.Point(3, 1);
            this.lblFilterFrom.Name = "lblFilterFrom";
            this.lblFilterFrom.Size = new System.Drawing.Size(41, 19);
            this.lblFilterFrom.TabIndex = 8;
            this.lblFilterFrom.Text = "From";
            this.lblFilterFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(211, 25);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 25);
            this.dateTimePicker1.TabIndex = 6;
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
            this.lblLanding.Size = new System.Drawing.Size(1078, 42);
            this.lblLanding.TabIndex = 9;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLanding.UseWaitCursor = true;
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
            this.linkLabelLogout.TabIndex = 12;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(1, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 26);
            this.panel2.TabIndex = 13;
            // 
            // btnUserBookingsSearch
            // 
            this.btnUserBookingsSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnUserBookingsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserBookingsSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserBookingsSearch.Location = new System.Drawing.Point(469, 23);
            this.btnUserBookingsSearch.Name = "btnUserBookingsSearch";
            this.btnUserBookingsSearch.Size = new System.Drawing.Size(75, 25);
            this.btnUserBookingsSearch.TabIndex = 14;
            this.btnUserBookingsSearch.Text = "Search";
            this.btnUserBookingsSearch.UseVisualStyleBackColor = false;
            // 
            // MyBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblLanding);
            this.Controls.Add(this.dataGridViewBookings);
            this.Name = "MyBookings";
            this.Text = "MyBookings";
            this.Load += new System.EventHandler(this.MyBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.panelLanding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Panel panelLanding;
        private System.Windows.Forms.Label lblFilterTo;
        private System.Windows.Forms.Label lblFilterFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lblLanding;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserBookingsSearch;
    }
}