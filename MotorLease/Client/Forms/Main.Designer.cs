
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblMain = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
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
            this.lblMain.Size = new System.Drawing.Size(800, 55);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Lawi Rides, Karibu!";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMain.UseWaitCursor = true;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelLogin.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogin.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogin.Location = new System.Drawing.Point(726, 18);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(51, 19);
            this.linkLabelLogin.TabIndex = 11;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.lblMain);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}