
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAllBookings = new System.Windows.Forms.DataGridView();
            this.panelFooterManageCars = new System.Windows.Forms.Panel();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.btnCreateNewBooking = new System.Windows.Forms.Button();
            this.dateTimePickerManageBookingsTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerManageBookingsFrom = new System.Windows.Forms.DateTimePicker();
            this.btnHomeFilter = new System.Windows.Forms.Button();
            this.labelManageBookingsTo = new System.Windows.Forms.Label();
            this.labelManageBookingsFrom = new System.Windows.Forms.Label();
            this.lblLanding = new System.Windows.Forms.Label();
            this.linkLabelManageBookingsLogout = new System.Windows.Forms.LinkLabel();
            this.linkLabelManageBookingsGoBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBookings)).BeginInit();
            this.panelLanding.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridAllBookings.Size = new System.Drawing.Size(882, 420);
            this.dataGridAllBookings.TabIndex = 11;
            this.dataGridAllBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllBookings_CellClick);
            // 
            // panelFooterManageCars
            // 
            this.panelFooterManageCars.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFooterManageCars.Location = new System.Drawing.Point(0, 519);
            this.panelFooterManageCars.Name = "panelFooterManageCars";
            this.panelFooterManageCars.Size = new System.Drawing.Size(882, 26);
            this.panelFooterManageCars.TabIndex = 14;
            // 
            // panelLanding
            // 
            this.panelLanding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLanding.Controls.Add(this.btnCreateNewBooking);
            this.panelLanding.Controls.Add(this.dateTimePickerManageBookingsTo);
            this.panelLanding.Controls.Add(this.dateTimePickerManageBookingsFrom);
            this.panelLanding.Controls.Add(this.btnHomeFilter);
            this.panelLanding.Controls.Add(this.labelManageBookingsTo);
            this.panelLanding.Controls.Add(this.labelManageBookingsFrom);
            this.panelLanding.Location = new System.Drawing.Point(0, 45);
            this.panelLanding.Name = "panelLanding";
            this.panelLanding.Size = new System.Drawing.Size(882, 52);
            this.panelLanding.TabIndex = 13;
            // 
            // btnCreateNewBooking
            // 
            this.btnCreateNewBooking.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreateNewBooking.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateNewBooking.FlatAppearance.BorderSize = 0;
            this.btnCreateNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateNewBooking.Location = new System.Drawing.Point(12, 22);
            this.btnCreateNewBooking.Name = "btnCreateNewBooking";
            this.btnCreateNewBooking.Size = new System.Drawing.Size(89, 27);
            this.btnCreateNewBooking.TabIndex = 27;
            this.btnCreateNewBooking.Text = "Create New";
            this.btnCreateNewBooking.UseVisualStyleBackColor = false;
            this.btnCreateNewBooking.Click += new System.EventHandler(this.CreateNewBooking);
            // 
            // dateTimePickerManageBookingsTo
            // 
            this.dateTimePickerManageBookingsTo.Location = new System.Drawing.Point(617, 26);
            this.dateTimePickerManageBookingsTo.Name = "dateTimePickerManageBookingsTo";
            this.dateTimePickerManageBookingsTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageBookingsTo.TabIndex = 25;
            // 
            // dateTimePickerManageBookingsFrom
            // 
            this.dateTimePickerManageBookingsFrom.Location = new System.Drawing.Point(411, 26);
            this.dateTimePickerManageBookingsFrom.Name = "dateTimePickerManageBookingsFrom";
            this.dateTimePickerManageBookingsFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageBookingsFrom.TabIndex = 24;
            // 
            // btnHomeFilter
            // 
            this.btnHomeFilter.BackColor = System.Drawing.Color.SlateGray;
            this.btnHomeFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnHomeFilter.FlatAppearance.BorderSize = 0;
            this.btnHomeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHomeFilter.Location = new System.Drawing.Point(823, 27);
            this.btnHomeFilter.Name = "btnHomeFilter";
            this.btnHomeFilter.Size = new System.Drawing.Size(54, 22);
            this.btnHomeFilter.TabIndex = 23;
            this.btnHomeFilter.Text = "Filter";
            this.btnHomeFilter.UseVisualStyleBackColor = false;
            this.btnHomeFilter.Click += new System.EventHandler(this.Filter);
            // 
            // labelManageBookingsTo
            // 
            this.labelManageBookingsTo.AutoSize = true;
            this.labelManageBookingsTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageBookingsTo.Location = new System.Drawing.Point(617, 4);
            this.labelManageBookingsTo.Name = "labelManageBookingsTo";
            this.labelManageBookingsTo.Size = new System.Drawing.Size(29, 19);
            this.labelManageBookingsTo.TabIndex = 22;
            this.labelManageBookingsTo.Text = "To:";
            // 
            // labelManageBookingsFrom
            // 
            this.labelManageBookingsFrom.AutoSize = true;
            this.labelManageBookingsFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageBookingsFrom.Location = new System.Drawing.Point(411, 4);
            this.labelManageBookingsFrom.Name = "labelManageBookingsFrom";
            this.labelManageBookingsFrom.Size = new System.Drawing.Size(48, 19);
            this.labelManageBookingsFrom.TabIndex = 21;
            this.labelManageBookingsFrom.Text = "From:";
            // 
            // lblLanding
            // 
            this.lblLanding.BackColor = System.Drawing.Color.SteelBlue;
            this.lblLanding.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLanding.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLanding.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLanding.Location = new System.Drawing.Point(0, 0);
            this.lblLanding.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblLanding.Name = "lblLanding";
            this.lblLanding.Size = new System.Drawing.Size(884, 42);
            this.lblLanding.TabIndex = 12;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLanding.UseWaitCursor = true;
            // 
            // linkLabelManageBookingsLogout
            // 
            this.linkLabelManageBookingsLogout.AutoSize = true;
            this.linkLabelManageBookingsLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageBookingsLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageBookingsLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageBookingsLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageBookingsLogout.Location = new System.Drawing.Point(820, 11);
            this.linkLabelManageBookingsLogout.Name = "linkLabelManageBookingsLogout";
            this.linkLabelManageBookingsLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelManageBookingsLogout.TabIndex = 17;
            this.linkLabelManageBookingsLogout.TabStop = true;
            this.linkLabelManageBookingsLogout.Text = "Logout";
            this.linkLabelManageBookingsLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // linkLabelManageBookingsGoBack
            // 
            this.linkLabelManageBookingsGoBack.AutoSize = true;
            this.linkLabelManageBookingsGoBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageBookingsGoBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageBookingsGoBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageBookingsGoBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelManageBookingsGoBack.Location = new System.Drawing.Point(12, 17);
            this.linkLabelManageBookingsGoBack.Name = "linkLabelManageBookingsGoBack";
            this.linkLabelManageBookingsGoBack.Size = new System.Drawing.Size(47, 13);
            this.linkLabelManageBookingsGoBack.TabIndex = 18;
            this.linkLabelManageBookingsGoBack.TabStop = true;
            this.linkLabelManageBookingsGoBack.Text = "Go Back";
            this.linkLabelManageBookingsGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // ManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 546);
            this.Controls.Add(this.linkLabelManageBookingsGoBack);
            this.Controls.Add(this.linkLabelManageBookingsLogout);
            this.Controls.Add(this.dataGridAllBookings);
            this.Controls.Add(this.panelFooterManageCars);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblLanding);
            this.Name = "ManageBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBookings";
            this.Load += new System.EventHandler(this.ManageBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBookings)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.panelLanding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAllBookings;
        private System.Windows.Forms.Panel panelFooterManageCars;
        private System.Windows.Forms.Panel panelLanding;
        public System.Windows.Forms.Label lblLanding;
        private System.Windows.Forms.LinkLabel linkLabelManageBookingsLogout;
        private System.Windows.Forms.LinkLabel linkLabelManageBookingsGoBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageBookingsTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageBookingsFrom;
        private System.Windows.Forms.Button btnHomeFilter;
        private System.Windows.Forms.Label labelManageBookingsTo;
        private System.Windows.Forms.Label labelManageBookingsFrom;
        private System.Windows.Forms.Button btnCreateNewBooking;
    }
}