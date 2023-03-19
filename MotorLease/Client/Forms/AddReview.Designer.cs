namespace MotorLease.Client.Forms
{
    partial class AddReview
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
            this.lblAddReview = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddReview
            // 
            this.lblAddReview.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAddReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddReview.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.lblAddReview.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddReview.Location = new System.Drawing.Point(0, 0);
            this.lblAddReview.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblAddReview.Name = "lblAddReview";
            this.lblAddReview.Size = new System.Drawing.Size(517, 42);
            this.lblAddReview.TabIndex = 10;
            this.lblAddReview.Text = "We appreciate your feedback!";
            this.lblAddReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddReview.UseWaitCursor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(29, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 86);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmitReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.Crimson;
            this.btnSubmitReview.Location = new System.Drawing.Point(397, 170);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(82, 35);
            this.btnSubmitReview.TabIndex = 12;
            this.btnSubmitReview.Text = "Submit";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            this.btnSubmitReview.Click += new System.EventHandler(this.SubmitReview);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotorLease.Properties.Resources.Background_Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 402);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblAddReview);
            this.Name = "AddReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReview";
            this.Load += new System.EventHandler(this.AddReview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblAddReview;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSubmitReview;
    }
}