
namespace MotorLease.Client.Forms
{
    partial class EditBooking
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
            this.components = new System.ComponentModel.Container();
            this.btnUserEditBookingSave = new System.Windows.Forms.Button();
            this.lblFilterToEditBooking = new System.Windows.Forms.Label();
            this.lblFilterFromEditBooking = new System.Windows.Forms.Label();
            this.dateTimePickerToEditBooking = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromEditBooking = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLanding = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.comboBoxMakeEditBooking = new System.Windows.Forms.ComboBox();
            this.carMakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxModelEditBooking = new System.Windows.Forms.ComboBox();
            this.carModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFromEditBooking = new System.Windows.Forms.Label();
            this.lblToEditBooking = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelEditBookingBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.carMakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserEditBookingSave
            // 
            this.btnUserEditBookingSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnUserEditBookingSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserEditBookingSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserEditBookingSave.Location = new System.Drawing.Point(807, 242);
            this.btnUserEditBookingSave.Name = "btnUserEditBookingSave";
            this.btnUserEditBookingSave.Size = new System.Drawing.Size(58, 25);
            this.btnUserEditBookingSave.TabIndex = 19;
            this.btnUserEditBookingSave.Text = "Save";
            this.btnUserEditBookingSave.UseVisualStyleBackColor = false;
            this.btnUserEditBookingSave.Click += new System.EventHandler(this.Save);
            // 
            // lblFilterToEditBooking
            // 
            this.lblFilterToEditBooking.AutoSize = true;
            this.lblFilterToEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterToEditBooking.Location = new System.Drawing.Point(654, 166);
            this.lblFilterToEditBooking.Name = "lblFilterToEditBooking";
            this.lblFilterToEditBooking.Size = new System.Drawing.Size(23, 19);
            this.lblFilterToEditBooking.TabIndex = 18;
            this.lblFilterToEditBooking.Text = "To";
            this.lblFilterToEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterFromEditBooking
            // 
            this.lblFilterFromEditBooking.AutoSize = true;
            this.lblFilterFromEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterFromEditBooking.Location = new System.Drawing.Point(418, 164);
            this.lblFilterFromEditBooking.Name = "lblFilterFromEditBooking";
            this.lblFilterFromEditBooking.Size = new System.Drawing.Size(41, 19);
            this.lblFilterFromEditBooking.TabIndex = 17;
            this.lblFilterFromEditBooking.Text = "From";
            this.lblFilterFromEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerToEditBooking
            // 
            this.dateTimePickerToEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerToEditBooking.Location = new System.Drawing.Point(654, 186);
            this.dateTimePickerToEditBooking.Name = "dateTimePickerToEditBooking";
            this.dateTimePickerToEditBooking.Size = new System.Drawing.Size(211, 25);
            this.dateTimePickerToEditBooking.TabIndex = 16;
            this.dateTimePickerToEditBooking.ValueChanged += new System.EventHandler(this.DateFromValueChanged);
            // 
            // dateTimePickerFromEditBooking
            // 
            this.dateTimePickerFromEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFromEditBooking.Location = new System.Drawing.Point(418, 186);
            this.dateTimePickerFromEditBooking.Name = "dateTimePickerFromEditBooking";
            this.dateTimePickerFromEditBooking.Size = new System.Drawing.Size(211, 25);
            this.dateTimePickerFromEditBooking.TabIndex = 15;
            this.dateTimePickerFromEditBooking.ValueChanged += new System.EventHandler(this.DateToValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 26);
            this.panel2.TabIndex = 20;
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
            this.lblLanding.Size = new System.Drawing.Size(1086, 42);
            this.lblLanding.TabIndex = 21;
            this.lblLanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLanding.UseWaitCursor = true;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelLogout.Location = new System.Drawing.Point(1012, 11);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelLogout.TabIndex = 23;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // comboBoxMakeEditBooking
            // 
            this.comboBoxMakeEditBooking.DataSource = this.carMakeBindingSource;
            this.comboBoxMakeEditBooking.DisplayMember = "Description";
            this.comboBoxMakeEditBooking.FormattingEnabled = true;
            this.comboBoxMakeEditBooking.Location = new System.Drawing.Point(418, 96);
            this.comboBoxMakeEditBooking.Name = "comboBoxMakeEditBooking";
            this.comboBoxMakeEditBooking.Size = new System.Drawing.Size(211, 23);
            this.comboBoxMakeEditBooking.TabIndex = 24;
            this.comboBoxMakeEditBooking.ValueMember = "Id";
            this.comboBoxMakeEditBooking.SelectedIndexChanged += new System.EventHandler(this.MakeSelectedIndexChanged);
            // 
            // carMakeBindingSource
            // 
            this.carMakeBindingSource.DataSource = typeof(MotorLease.Domain.Models.CarMake);
            // 
            // comboBoxModelEditBooking
            // 
            this.comboBoxModelEditBooking.DataSource = this.carModelBindingSource;
            this.comboBoxModelEditBooking.DisplayMember = "Description";
            this.comboBoxModelEditBooking.FormattingEnabled = true;
            this.comboBoxModelEditBooking.Location = new System.Drawing.Point(654, 96);
            this.comboBoxModelEditBooking.Name = "comboBoxModelEditBooking";
            this.comboBoxModelEditBooking.Size = new System.Drawing.Size(211, 23);
            this.comboBoxModelEditBooking.TabIndex = 25;
            this.comboBoxModelEditBooking.ValueMember = "Id";
            this.comboBoxModelEditBooking.SelectedIndexChanged += new System.EventHandler(this.ModelSelectedIndexChanged);
            // 
            // carModelBindingSource
            // 
            this.carModelBindingSource.DataSource = typeof(MotorLease.Domain.Models.CarModel);
            // 
            // lblFromEditBooking
            // 
            this.lblFromEditBooking.AutoSize = true;
            this.lblFromEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromEditBooking.Location = new System.Drawing.Point(418, 74);
            this.lblFromEditBooking.Name = "lblFromEditBooking";
            this.lblFromEditBooking.Size = new System.Drawing.Size(43, 19);
            this.lblFromEditBooking.TabIndex = 26;
            this.lblFromEditBooking.Text = "Make";
            this.lblFromEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToEditBooking
            // 
            this.lblToEditBooking.AutoSize = true;
            this.lblToEditBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToEditBooking.Location = new System.Drawing.Point(654, 74);
            this.lblToEditBooking.Name = "lblToEditBooking";
            this.lblToEditBooking.Size = new System.Drawing.Size(48, 19);
            this.lblToEditBooking.TabIndex = 27;
            this.lblToEditBooking.Text = "Model";
            this.lblToEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelEditBookingBack
            // 
            this.linkLabelEditBookingBack.AutoSize = true;
            this.linkLabelEditBookingBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelEditBookingBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelEditBookingBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelEditBookingBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelEditBookingBack.Location = new System.Drawing.Point(12, 16);
            this.linkLabelEditBookingBack.Name = "linkLabelEditBookingBack";
            this.linkLabelEditBookingBack.Size = new System.Drawing.Size(47, 13);
            this.linkLabelEditBookingBack.TabIndex = 22;
            this.linkLabelEditBookingBack.TabStop = true;
            this.linkLabelEditBookingBack.Text = "Go Back";
            this.linkLabelEditBookingBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // EditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblToEditBooking);
            this.Controls.Add(this.lblFromEditBooking);
            this.Controls.Add(this.comboBoxModelEditBooking);
            this.Controls.Add(this.comboBoxMakeEditBooking);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.linkLabelEditBookingBack);
            this.Controls.Add(this.lblLanding);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUserEditBookingSave);
            this.Controls.Add(this.lblFilterToEditBooking);
            this.Controls.Add(this.lblFilterFromEditBooking);
            this.Controls.Add(this.dateTimePickerToEditBooking);
            this.Controls.Add(this.dateTimePickerFromEditBooking);
            this.Name = "EditBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBookingForm";
            this.Load += new System.EventHandler(this.EditBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carMakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUserEditBookingSave;
        private System.Windows.Forms.Label lblFilterToEditBooking;
        private System.Windows.Forms.Label lblFilterFromEditBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerToEditBooking;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromEditBooking;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblLanding;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.ComboBox comboBoxMakeEditBooking;
        private System.Windows.Forms.ComboBox comboBoxModelEditBooking;
        private System.Windows.Forms.Label lblFromEditBooking;
        private System.Windows.Forms.Label lblToEditBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource carMakeBindingSource;
        private System.Windows.Forms.BindingSource carModelBindingSource;
        private System.Windows.Forms.LinkLabel linkLabelEditBookingBack;
    }
}