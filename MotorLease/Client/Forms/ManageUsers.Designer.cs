
namespace MotorLease.Client.Forms
{
    partial class ManageUsers
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
            this.dataGridAllUsers = new System.Windows.Forms.DataGridView();
            this.panelFooterManageUsers = new System.Windows.Forms.Panel();
            this.panelManageUsers = new System.Windows.Forms.Panel();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.dateTimePickerManageUsersTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerManageUsersFrom = new System.Windows.Forms.DateTimePicker();
            this.btnManageUsersFilter = new System.Windows.Forms.Button();
            this.labelManageUsersTo = new System.Windows.Forms.Label();
            this.labelManageUsersFrom = new System.Windows.Forms.Label();
            this.lblMangeUsers = new System.Windows.Forms.Label();
            this.linkLabelManageUsersLogout = new System.Windows.Forms.LinkLabel();
            this.linkLabelManageUsersBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllUsers)).BeginInit();
            this.panelManageUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAllUsers
            // 
            this.dataGridAllUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllUsers.Location = new System.Drawing.Point(0, 101);
            this.dataGridAllUsers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridAllUsers.Name = "dataGridAllUsers";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllUsers.RowTemplate.Height = 25;
            this.dataGridAllUsers.Size = new System.Drawing.Size(851, 420);
            this.dataGridAllUsers.TabIndex = 11;
            this.dataGridAllUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllUsers_CellClick);
            // 
            // panelFooterManageUsers
            // 
            this.panelFooterManageUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFooterManageUsers.Location = new System.Drawing.Point(0, 519);
            this.panelFooterManageUsers.Name = "panelFooterManageUsers";
            this.panelFooterManageUsers.Size = new System.Drawing.Size(851, 26);
            this.panelFooterManageUsers.TabIndex = 14;
            // 
            // panelManageUsers
            // 
            this.panelManageUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelManageUsers.Controls.Add(this.btnCreateNewUser);
            this.panelManageUsers.Controls.Add(this.dateTimePickerManageUsersTo);
            this.panelManageUsers.Controls.Add(this.dateTimePickerManageUsersFrom);
            this.panelManageUsers.Controls.Add(this.btnManageUsersFilter);
            this.panelManageUsers.Controls.Add(this.labelManageUsersTo);
            this.panelManageUsers.Controls.Add(this.labelManageUsersFrom);
            this.panelManageUsers.Location = new System.Drawing.Point(0, 45);
            this.panelManageUsers.Name = "panelManageUsers";
            this.panelManageUsers.Size = new System.Drawing.Size(851, 52);
            this.panelManageUsers.TabIndex = 13;
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreateNewUser.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateNewUser.FlatAppearance.BorderSize = 0;
            this.btnCreateNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateNewUser.Location = new System.Drawing.Point(12, 22);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(89, 27);
            this.btnCreateNewUser.TabIndex = 26;
            this.btnCreateNewUser.Text = "Create New";
            this.btnCreateNewUser.UseVisualStyleBackColor = false;
            this.btnCreateNewUser.Click += new System.EventHandler(this.CreateNewUser);
            // 
            // dateTimePickerManageUsersTo
            // 
            this.dateTimePickerManageUsersTo.Location = new System.Drawing.Point(571, 26);
            this.dateTimePickerManageUsersTo.Name = "dateTimePickerManageUsersTo";
            this.dateTimePickerManageUsersTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageUsersTo.TabIndex = 25;
            // 
            // dateTimePickerManageUsersFrom
            // 
            this.dateTimePickerManageUsersFrom.Location = new System.Drawing.Point(365, 26);
            this.dateTimePickerManageUsersFrom.Name = "dateTimePickerManageUsersFrom";
            this.dateTimePickerManageUsersFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerManageUsersFrom.TabIndex = 24;
            // 
            // btnManageUsersFilter
            // 
            this.btnManageUsersFilter.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageUsersFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUsersFilter.FlatAppearance.BorderSize = 0;
            this.btnManageUsersFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageUsersFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageUsersFilter.Location = new System.Drawing.Point(786, 27);
            this.btnManageUsersFilter.Name = "btnManageUsersFilter";
            this.btnManageUsersFilter.Size = new System.Drawing.Size(54, 22);
            this.btnManageUsersFilter.TabIndex = 23;
            this.btnManageUsersFilter.Text = "Filter";
            this.btnManageUsersFilter.UseVisualStyleBackColor = false;
            this.btnManageUsersFilter.Click += new System.EventHandler(this.Filter);
            // 
            // labelManageUsersTo
            // 
            this.labelManageUsersTo.AutoSize = true;
            this.labelManageUsersTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageUsersTo.Location = new System.Drawing.Point(571, 4);
            this.labelManageUsersTo.Name = "labelManageUsersTo";
            this.labelManageUsersTo.Size = new System.Drawing.Size(29, 19);
            this.labelManageUsersTo.TabIndex = 22;
            this.labelManageUsersTo.Text = "To:";
            // 
            // labelManageUsersFrom
            // 
            this.labelManageUsersFrom.AutoSize = true;
            this.labelManageUsersFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageUsersFrom.Location = new System.Drawing.Point(365, 4);
            this.labelManageUsersFrom.Name = "labelManageUsersFrom";
            this.labelManageUsersFrom.Size = new System.Drawing.Size(48, 19);
            this.labelManageUsersFrom.TabIndex = 21;
            this.labelManageUsersFrom.Text = "From:";
            // 
            // lblMangeUsers
            // 
            this.lblMangeUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMangeUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMangeUsers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMangeUsers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMangeUsers.Location = new System.Drawing.Point(0, 0);
            this.lblMangeUsers.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblMangeUsers.Name = "lblMangeUsers";
            this.lblMangeUsers.Size = new System.Drawing.Size(852, 42);
            this.lblMangeUsers.TabIndex = 12;
            this.lblMangeUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMangeUsers.UseWaitCursor = true;
            // 
            // linkLabelManageUsersLogout
            // 
            this.linkLabelManageUsersLogout.AutoSize = true;
            this.linkLabelManageUsersLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageUsersLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageUsersLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageUsersLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageUsersLogout.Location = new System.Drawing.Point(778, 11);
            this.linkLabelManageUsersLogout.Name = "linkLabelManageUsersLogout";
            this.linkLabelManageUsersLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelManageUsersLogout.TabIndex = 17;
            this.linkLabelManageUsersLogout.TabStop = true;
            this.linkLabelManageUsersLogout.Text = "Logout";
            this.linkLabelManageUsersLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // linkLabelManageUsersBack
            // 
            this.linkLabelManageUsersBack.AutoSize = true;
            this.linkLabelManageUsersBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelManageUsersBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelManageUsersBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelManageUsersBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelManageUsersBack.Location = new System.Drawing.Point(12, 17);
            this.linkLabelManageUsersBack.Name = "linkLabelManageUsersBack";
            this.linkLabelManageUsersBack.Size = new System.Drawing.Size(47, 13);
            this.linkLabelManageUsersBack.TabIndex = 18;
            this.linkLabelManageUsersBack.TabStop = true;
            this.linkLabelManageUsersBack.Text = "Go Back";
            this.linkLabelManageUsersBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 545);
            this.Controls.Add(this.linkLabelManageUsersBack);
            this.Controls.Add(this.linkLabelManageUsersLogout);
            this.Controls.Add(this.dataGridAllUsers);
            this.Controls.Add(this.panelFooterManageUsers);
            this.Controls.Add(this.panelManageUsers);
            this.Controls.Add(this.lblMangeUsers);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllUsers)).EndInit();
            this.panelManageUsers.ResumeLayout(false);
            this.panelManageUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAllUsers;
        private System.Windows.Forms.Panel panelFooterManageUsers;
        private System.Windows.Forms.Panel panelManageUsers;
        public System.Windows.Forms.Label lblMangeUsers;
        private System.Windows.Forms.LinkLabel linkLabelManageUsersLogout;
        private System.Windows.Forms.LinkLabel linkLabelManageUsersBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageUsersTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerManageUsersFrom;
        private System.Windows.Forms.Button btnManageUsersFilter;
        private System.Windows.Forms.Label labelManageUsersTo;
        private System.Windows.Forms.Label labelManageUsersFrom;
        private System.Windows.Forms.Button btnCreateNewUser;
    }
}