
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
            System.Windows.Forms.Label lblWelcome;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.dataGridAllUsers = new System.Windows.Forms.DataGridView();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.lblLanding = new System.Windows.Forms.Label();
            lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllUsers)).BeginInit();
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
            // dataGridAllUsers
            // 
            this.dataGridAllUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllUsers.Location = new System.Drawing.Point(0, 101);
            this.dataGridAllUsers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridAllUsers.Name = "dataGridAllUsers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAllUsers.RowTemplate.Height = 25;
            this.dataGridAllUsers.Size = new System.Drawing.Size(1067, 420);
            this.dataGridAllUsers.TabIndex = 11;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.SlateGray;
            this.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateUser.Location = new System.Drawing.Point(3, 21);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(124, 27);
            this.btnCreateUser.TabIndex = 5;
            this.btnCreateUser.Text = "Create New";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
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
            this.panelLanding.Controls.Add(this.btnCreateUser);
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
            this.lblLanding.Size = new System.Drawing.Size(1068, 42);
            this.lblLanding.TabIndex = 12;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLanding.UseWaitCursor = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 545);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(lblWelcome);
            this.Controls.Add(this.dataGridAllUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblLanding);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllUsers)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.DataGridView dataGridAllUsers;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLanding;
        public System.Windows.Forms.Label lblLanding;
    }
}