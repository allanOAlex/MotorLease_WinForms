
namespace MotorLease.Client.Forms
{
    partial class Main
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
            this.lblMain = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMain.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(885, 55);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Lawi Rides, Karibu!";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMain.UseWaitCursor = true;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelLogin.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogin.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogin.Location = new System.Drawing.Point(822, 18);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(51, 19);
            this.linkLabelLogin.TabIndex = 11;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackgroundImage = global::MotorLease.Properties.Resources.Background_Main;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.InitialImage = global::MotorLease.Properties.Resources.Background_Main;
            this.pictureBoxMain.Location = new System.Drawing.Point(655, 77);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(145, 138);
            this.pictureBoxMain.TabIndex = 13;
            this.pictureBoxMain.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::MotorLease.Properties.Resources.Background_Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 561);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.lblMain);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}