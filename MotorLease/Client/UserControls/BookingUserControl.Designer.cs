
namespace MotorLease.Client.UserControls
{
    partial class BookingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.lblBookingMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(15, 55);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(48, 19);
            this.labelDateFrom.TabIndex = 2;
            this.labelDateFrom.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(233, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Silver;
            this.buttonBook.Location = new System.Drawing.Point(358, 116);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 37);
            this.buttonBook.TabIndex = 4;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(277, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(233, 55);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(29, 19);
            this.labelDateTo.TabIndex = 6;
            this.labelDateTo.Text = "To:";
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
            this.lblBookingMsg.Size = new System.Drawing.Size(447, 42);
            this.lblBookingMsg.TabIndex = 7;
            this.lblBookingMsg.Text = "MotorLease Booking";
            this.lblBookingMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBookingMsg.UseWaitCursor = true;
            // 
            // BookingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblBookingMsg);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "BookingUserControl";
            this.Size = new System.Drawing.Size(447, 203);
            this.Load += new System.EventHandler(this.BookingUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDateTo;
        public System.Windows.Forms.Label lblBookingMsg;
    }
}
