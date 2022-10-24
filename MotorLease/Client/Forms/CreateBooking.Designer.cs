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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.carModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.carMakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDateTo = new System.Windows.Forms.Label();
            this.btnAbortBooking = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblCreateBooking = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.linkLabelGoBackCreateBooking = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateBookingLogout = new System.Windows.Forms.LinkLabel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelIdNumber = new System.Windows.Forms.Label();
            this.textBoxIdNo = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.lblLabelUnitPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMakeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Make";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DataSource = this.carModelBindingSource;
            this.comboBoxModel.DisplayMember = "Description";
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(239, 296);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 23);
            this.comboBoxModel.TabIndex = 26;
            this.comboBoxModel.ValueMember = "Id";
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.Model_SelectedIndexChanged);
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.DataSource = this.carMakeBindingSource;
            this.comboBoxMake.DisplayMember = "Description";
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(21, 296);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(200, 23);
            this.comboBoxMake.TabIndex = 25;
            this.comboBoxMake.ValueMember = "Id";
            this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.Make_SelectedIndexChanged);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(239, 335);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(29, 19);
            this.labelDateTo.TabIndex = 24;
            this.labelDateTo.Text = "To:";
            // 
            // btnAbortBooking
            // 
            this.btnAbortBooking.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbortBooking.Location = new System.Drawing.Point(239, 395);
            this.btnAbortBooking.Name = "btnAbortBooking";
            this.btnAbortBooking.Size = new System.Drawing.Size(99, 26);
            this.btnAbortBooking.TabIndex = 23;
            this.btnAbortBooking.Text = "Cancel";
            this.btnAbortBooking.UseVisualStyleBackColor = false;
            this.btnAbortBooking.Click += new System.EventHandler(this.AbortBooking);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Silver;
            this.buttonBook.Location = new System.Drawing.Point(344, 395);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(95, 26);
            this.buttonBook.TabIndex = 22;
            this.buttonBook.Text = "Save";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.Save);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(239, 357);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTo.TabIndex = 21;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(21, 335);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(48, 19);
            this.labelDateFrom.TabIndex = 20;
            this.labelDateFrom.Text = "From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(21, 357);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFrom.TabIndex = 19;
            // 
            // lblCreateBooking
            // 
            this.lblCreateBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCreateBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreateBooking.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreateBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCreateBooking.Location = new System.Drawing.Point(0, 0);
            this.lblCreateBooking.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblCreateBooking.Name = "lblCreateBooking";
            this.lblCreateBooking.Size = new System.Drawing.Size(531, 42);
            this.lblCreateBooking.TabIndex = 29;
            this.lblCreateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreateBooking.UseWaitCursor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(19, 95);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(202, 23);
            this.textBoxFirstName.TabIndex = 30;
            // 
            // linkLabelGoBackCreateBooking
            // 
            this.linkLabelGoBackCreateBooking.AutoSize = true;
            this.linkLabelGoBackCreateBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelGoBackCreateBooking.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGoBackCreateBooking.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelGoBackCreateBooking.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelGoBackCreateBooking.Location = new System.Drawing.Point(12, 16);
            this.linkLabelGoBackCreateBooking.Name = "linkLabelGoBackCreateBooking";
            this.linkLabelGoBackCreateBooking.Size = new System.Drawing.Size(47, 13);
            this.linkLabelGoBackCreateBooking.TabIndex = 31;
            this.linkLabelGoBackCreateBooking.TabStop = true;
            this.linkLabelGoBackCreateBooking.Text = "Go Back";
            this.linkLabelGoBackCreateBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // linkLabelCreateBookingLogout
            // 
            this.linkLabelCreateBookingLogout.AutoSize = true;
            this.linkLabelCreateBookingLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelCreateBookingLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelCreateBookingLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelCreateBookingLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelCreateBookingLogout.Location = new System.Drawing.Point(454, 10);
            this.linkLabelCreateBookingLogout.Name = "linkLabelCreateBookingLogout";
            this.linkLabelCreateBookingLogout.Size = new System.Drawing.Size(62, 19);
            this.linkLabelCreateBookingLogout.TabIndex = 32;
            this.linkLabelCreateBookingLogout.TabStop = true;
            this.linkLabelCreateBookingLogout.Text = "Logout";
            this.linkLabelCreateBookingLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(239, 95);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 23);
            this.textBoxLastName.TabIndex = 33;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(19, 156);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(202, 23);
            this.textBoxPhone.TabIndex = 34;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(21, 73);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(81, 19);
            this.labelFirstName.TabIndex = 35;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(239, 73);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(79, 19);
            this.labelLastName.TabIndex = 36;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(19, 134);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 19);
            this.labelPhone.TabIndex = 37;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(239, 156);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 23);
            this.textBoxAddress.TabIndex = 38;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(239, 134);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 19);
            this.labelAddress.TabIndex = 39;
            this.labelAddress.Text = "Address";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.labelUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUnitPrice.Location = new System.Drawing.Point(77, 396);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(19, 21);
            this.labelUnitPrice.TabIndex = 40;
            this.labelUnitPrice.Text = "0";
            // 
            // labelIdNumber
            // 
            this.labelIdNumber.AutoSize = true;
            this.labelIdNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdNumber.Location = new System.Drawing.Point(24, 205);
            this.labelIdNumber.Name = "labelIdNumber";
            this.labelIdNumber.Size = new System.Drawing.Size(50, 19);
            this.labelIdNumber.TabIndex = 42;
            this.labelIdNumber.Text = "Id No.";
            // 
            // textBoxIdNo
            // 
            this.textBoxIdNo.Location = new System.Drawing.Point(21, 227);
            this.textBoxIdNo.Name = "textBoxIdNo";
            this.textBoxIdNo.Size = new System.Drawing.Size(202, 23);
            this.textBoxIdNo.TabIndex = 43;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCustomerName.Location = new System.Drawing.Point(308, 229);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(131, 21);
            this.labelCustomerName.TabIndex = 44;
            this.labelCustomerName.Text = "Customer Names";
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchUser.Location = new System.Drawing.Point(239, 227);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(59, 26);
            this.buttonSearchUser.TabIndex = 45;
            this.buttonSearchUser.Text = "Search";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.SearchUser);
            // 
            // lblLabelUnitPrice
            // 
            this.lblLabelUnitPrice.AutoSize = true;
            this.lblLabelUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLabelUnitPrice.Location = new System.Drawing.Point(24, 395);
            this.lblLabelUnitPrice.Name = "lblLabelUnitPrice";
            this.lblLabelUnitPrice.Size = new System.Drawing.Size(47, 19);
            this.lblLabelUnitPrice.TabIndex = 46;
            this.lblLabelUnitPrice.Text = "Price:";
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.lblLabelUnitPrice);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textBoxIdNo);
            this.Controls.Add(this.labelIdNumber);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.linkLabelCreateBookingLogout);
            this.Controls.Add(this.linkLabelGoBackCreateBooking);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblCreateBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.btnAbortBooking);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "CreateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMakeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Button btnAbortBooking;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        public System.Windows.Forms.Label lblCreateBooking;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.LinkLabel linkLabelGoBackCreateBooking;
        private System.Windows.Forms.LinkLabel linkLabelCreateBookingLogout;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.BindingSource carModelBindingSource;
        private System.Windows.Forms.BindingSource carMakeBindingSource;
        private System.Windows.Forms.Label labelIdNumber;
        private System.Windows.Forms.TextBox textBoxIdNo;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Label lblLabelUnitPrice;
    }
}