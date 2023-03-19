namespace MotorLease.Client.Forms
{
    partial class UserReviews
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
            this.lblUserReviews = new System.Windows.Forms.Label();
            this.linkLabelUserReviewBack = new System.Windows.Forms.LinkLabel();
            this.linkLabelLogoutUserReview = new System.Windows.Forms.LinkLabel();
            this.dataGridViewUserReviews = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserReviews
            // 
            this.lblUserReviews.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUserReviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserReviews.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserReviews.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUserReviews.Location = new System.Drawing.Point(0, 0);
            this.lblUserReviews.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserReviews.Name = "lblUserReviews";
            this.lblUserReviews.Size = new System.Drawing.Size(1005, 42);
            this.lblUserReviews.TabIndex = 10;
            this.lblUserReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserReviews.UseWaitCursor = true;
            // 
            // linkLabelUserReviewBack
            // 
            this.linkLabelUserReviewBack.AutoSize = true;
            this.linkLabelUserReviewBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelUserReviewBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelUserReviewBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelUserReviewBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelUserReviewBack.Location = new System.Drawing.Point(12, 16);
            this.linkLabelUserReviewBack.Name = "linkLabelUserReviewBack";
            this.linkLabelUserReviewBack.Size = new System.Drawing.Size(47, 13);
            this.linkLabelUserReviewBack.TabIndex = 20;
            this.linkLabelUserReviewBack.TabStop = true;
            this.linkLabelUserReviewBack.Text = "Go Back";
            this.linkLabelUserReviewBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // linkLabelLogoutUserReview
            // 
            this.linkLabelLogoutUserReview.AutoSize = true;
            this.linkLabelLogoutUserReview.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelLogoutUserReview.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogoutUserReview.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogoutUserReview.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogoutUserReview.Location = new System.Drawing.Point(931, 11);
            this.linkLabelLogoutUserReview.Name = "linkLabelLogoutUserReview";
            this.linkLabelLogoutUserReview.Size = new System.Drawing.Size(62, 19);
            this.linkLabelLogoutUserReview.TabIndex = 21;
            this.linkLabelLogoutUserReview.TabStop = true;
            this.linkLabelLogoutUserReview.Text = "Logout";
            this.linkLabelLogoutUserReview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // dataGridViewUserReviews
            // 
            this.dataGridViewUserReviews.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUserReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserReviews.Location = new System.Drawing.Point(0, 47);
            this.dataGridViewUserReviews.Name = "dataGridViewUserReviews";
            this.dataGridViewUserReviews.RowTemplate.Height = 25;
            this.dataGridViewUserReviews.Size = new System.Drawing.Size(1004, 370);
            this.dataGridViewUserReviews.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 26);
            this.panel1.TabIndex = 23;
            // 
            // UserReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewUserReviews);
            this.Controls.Add(this.linkLabelLogoutUserReview);
            this.Controls.Add(this.linkLabelUserReviewBack);
            this.Controls.Add(this.lblUserReviews);
            this.Name = "UserReviews";
            this.Text = "UserReviews";
            this.Load += new System.EventHandler(this.UserReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUserReviews;
        private System.Windows.Forms.LinkLabel linkLabelUserReviewBack;
        private System.Windows.Forms.LinkLabel linkLabelLogoutUserReview;
        private System.Windows.Forms.DataGridView dataGridViewUserReviews;
        private System.Windows.Forms.Panel panel1;
    }
}