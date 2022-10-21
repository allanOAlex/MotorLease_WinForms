
namespace MotorLease.Client.Forms
{
    partial class CreateBooking
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookingMsg
            // 
            this.lblBookingMsg.BackColor = System.Drawing.Color.SlateGray;
            this.lblBookingMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookingMsg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBookingMsg.Location = new System.Drawing.Point(0, 0);
            this.lblBookingMsg.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblBookingMsg.Name = "lblBookingMsg";
            this.lblBookingMsg.Size = new System.Drawing.Size(532, 42);
            this.lblBookingMsg.TabIndex = 8;
            this.lblBookingMsg.Text = "MotorLease Booking";
            this.lblBookingMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBookingMsg.UseWaitCursor = true;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(266, 132);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(29, 19);
            this.labelDateTo.TabIndex = 14;
            this.labelDateTo.Text = "To:";
            // 
            // btnAbortBooking
            // 
            this.btnAbortBooking.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbortBooking.Location = new System.Drawing.Point(310, 193);
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
            this.buttonBook.Location = new System.Drawing.Point(391, 193);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 37);
            this.buttonBook.TabIndex = 12;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.PerformBooking);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(266, 155);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTo.TabIndex = 11;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(48, 132);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(48, 19);
            this.labelDateFrom.TabIndex = 10;
            this.labelDateFrom.Text = "From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(48, 155);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(266, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 23);
            this.comboBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(266, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.btnAbortBooking);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.lblBookingMsg);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotorLease";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}