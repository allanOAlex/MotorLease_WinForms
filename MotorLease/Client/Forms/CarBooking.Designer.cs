
namespace MotorLease.Client.Forms
{
    partial class CarBooking
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
            this.lblBookingMsg = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.btnAbortBooking = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.linkLabelGoBackCarBooking = new System.Windows.Forms.LinkLabel();
            this.linkLabelHomeLogoutCarBooking = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingMsg
            // 
            this.lblBookingMsg.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBookingMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookingMsg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBookingMsg.Location = new System.Drawing.Point(0, 0);
            this.lblBookingMsg.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblBookingMsg.Name = "lblBookingMsg";
            this.lblBookingMsg.Size = new System.Drawing.Size(444, 42);
            this.lblBookingMsg.TabIndex = 8;
            this.lblBookingMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBookingMsg.UseWaitCursor = true;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(230, 297);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(29, 19);
            this.labelDateTo.TabIndex = 14;
            this.labelDateTo.Text = "To:";
            // 
            // btnAbortBooking
            // 
            this.btnAbortBooking.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbortBooking.Location = new System.Drawing.Point(274, 358);
            this.btnAbortBooking.Name = "btnAbortBooking";
            this.btnAbortBooking.Size = new System.Drawing.Size(75, 37);
            this.btnAbortBooking.TabIndex = 13;
            this.btnAbortBooking.Text = "Cancel";
            this.btnAbortBooking.UseVisualStyleBackColor = false;
            this.btnAbortBooking.Click += new System.EventHandler(this.AbortBooking);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Silver;
            this.buttonBook.Location = new System.Drawing.Point(355, 358);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 37);
            this.buttonBook.TabIndex = 12;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.InitiateBooking);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(230, 320);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTo.TabIndex = 11;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(12, 297);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(48, 19);
            this.labelDateFrom.TabIndex = 10;
            this.labelDateFrom.Text = "From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 320);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // linkLabelGoBackCarBooking
            // 
            this.linkLabelGoBackCarBooking.AutoSize = true;
            this.linkLabelGoBackCarBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelGoBackCarBooking.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGoBackCarBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelGoBackCarBooking.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelGoBackCarBooking.Location = new System.Drawing.Point(12, 16);
            this.linkLabelGoBackCarBooking.Name = "linkLabelGoBackCarBooking";
            this.linkLabelGoBackCarBooking.Size = new System.Drawing.Size(47, 13);
            this.linkLabelGoBackCarBooking.TabIndex = 15;
            this.linkLabelGoBackCarBooking.TabStop = true;
            this.linkLabelGoBackCarBooking.Text = "Go Back";
            this.linkLabelGoBackCarBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // linkLabelHomeLogoutCarBooking
            // 
            this.linkLabelHomeLogoutCarBooking.AutoSize = true;
            this.linkLabelHomeLogoutCarBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelHomeLogoutCarBooking.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelHomeLogoutCarBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelHomeLogoutCarBooking.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelHomeLogoutCarBooking.Location = new System.Drawing.Point(733, 11);
            this.linkLabelHomeLogoutCarBooking.Name = "linkLabelHomeLogoutCarBooking";
            this.linkLabelHomeLogoutCarBooking.Size = new System.Drawing.Size(62, 19);
            this.linkLabelHomeLogoutCarBooking.TabIndex = 16;
            this.linkLabelHomeLogoutCarBooking.TabStop = true;
            this.linkLabelHomeLogoutCarBooking.Text = "Logout";
            this.linkLabelHomeLogoutCarBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CarBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelHomeLogoutCarBooking);
            this.Controls.Add(this.linkLabelGoBackCarBooking);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.btnAbortBooking);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.lblBookingMsg);
            this.Name = "CarBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotorLease";
            this.Load += new System.EventHandler(this.CarBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBookingMsg;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Button btnAbortBooking;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.LinkLabel linkLabelGoBackCarBooking;
        private System.Windows.Forms.LinkLabel linkLabelHomeLogoutCarBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}