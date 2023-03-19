
namespace MotorLease.Client.Forms
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAllCars = new System.Windows.Forms.DataGridView();
            this.lblHome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLanding = new System.Windows.Forms.Panel();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.btnHomeFilter = new System.Windows.Forms.Button();
            this.labelHomeCarModel = new System.Windows.Forms.Label();
            this.labelHomeCarMake = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnMyBookings = new System.Windows.Forms.Button();
            this.panelFooterHome = new System.Windows.Forms.Panel();
            this.linkLabelHomeLogout = new System.Windows.Forms.LinkLabel();
            this.linkLabelGoBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllCars)).BeginInit();
            this.panelLanding.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAllCars
            // 
            this.dataGridAllCars.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllCars.Location = new System.Drawing.Point(0, 165);
            this.dataGridAllCars.Margin = new System.Windows.Forms.Padding(4, 2, 4, 5);
            this.dataGridAllCars.Name = "dataGridAllCars";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllCars.RowHeadersWidth = 62;
            this.dataGridAllCars.RowTemplate.Height = 25;
            this.dataGridAllCars.Size = new System.Drawing.Size(1241, 707);
            this.dataGridAllCars.TabIndex = 1;
            this.dataGridAllCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllMotors_CellClick);
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHome.Location = new System.Drawing.Point(0, 0);
            this.lblHome.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(1241, 70);
            this.lblHome.TabIndex = 2;
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Type",
            "Make",
            "Price",
            "Availability"});
            this.comboBox1.Location = new System.Drawing.Point(1347, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1434, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLanding
            // 
            this.panelLanding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLanding.Controls.Add(this.buttonReviews);
            this.panelLanding.Controls.Add(this.btnHomeFilter);
            this.panelLanding.Controls.Add(this.labelHomeCarModel);
            this.panelLanding.Controls.Add(this.labelHomeCarMake);
            this.panelLanding.Controls.Add(this.comboBox3);
            this.panelLanding.Controls.Add(this.comboBox2);
            this.panelLanding.Controls.Add(this.btnManageCars);
            this.panelLanding.Controls.Add(this.btnManageBookings);
            this.panelLanding.Controls.Add(this.btnManageUsers);
            this.panelLanding.Controls.Add(this.btnMyBookings);
            this.panelLanding.Controls.Add(this.comboBox1);
            this.panelLanding.Controls.Add(this.label1);
            this.panelLanding.Location = new System.Drawing.Point(0, 78);
            this.panelLanding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLanding.Name = "panelLanding";
            this.panelLanding.Size = new System.Drawing.Size(1241, 87);
            this.panelLanding.TabIndex = 5;
            // 
            // buttonReviews
            // 
            this.buttonReviews.BackColor = System.Drawing.Color.SlateGray;
            this.buttonReviews.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonReviews.FlatAppearance.BorderSize = 0;
            this.buttonReviews.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReviews.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonReviews.Location = new System.Drawing.Point(1103, 40);
            this.buttonReviews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(134, 37);
            this.buttonReviews.TabIndex = 19;
            this.buttonReviews.Text = "User Reviews";
            this.buttonReviews.UseMnemonic = false;
            this.buttonReviews.UseVisualStyleBackColor = false;
            this.buttonReviews.Click += new System.EventHandler(this.GetUserReviews);
            // 
            // btnHomeFilter
            // 
            this.btnHomeFilter.BackColor = System.Drawing.Color.SlateGray;
            this.btnHomeFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnHomeFilter.FlatAppearance.BorderSize = 0;
            this.btnHomeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHomeFilter.Location = new System.Drawing.Point(990, 40);
            this.btnHomeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHomeFilter.Name = "btnHomeFilter";
            this.btnHomeFilter.Size = new System.Drawing.Size(77, 37);
            this.btnHomeFilter.TabIndex = 18;
            this.btnHomeFilter.Text = "Filter";
            this.btnHomeFilter.UseVisualStyleBackColor = false;
            this.btnHomeFilter.Click += new System.EventHandler(this.Filter);
            // 
            // labelHomeCarModel
            // 
            this.labelHomeCarModel.AutoSize = true;
            this.labelHomeCarModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHomeCarModel.Location = new System.Drawing.Point(853, 5);
            this.labelHomeCarModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeCarModel.Name = "labelHomeCarModel";
            this.labelHomeCarModel.Size = new System.Drawing.Size(77, 28);
            this.labelHomeCarModel.TabIndex = 17;
            this.labelHomeCarModel.Text = "Model:";
            // 
            // labelHomeCarMake
            // 
            this.labelHomeCarMake.AutoSize = true;
            this.labelHomeCarMake.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHomeCarMake.Location = new System.Drawing.Point(707, 5);
            this.labelHomeCarMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeCarMake.Name = "labelHomeCarMake";
            this.labelHomeCarMake.Size = new System.Drawing.Size(69, 28);
            this.labelHomeCarMake.TabIndex = 16;
            this.labelHomeCarMake.Text = "Make:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(853, 40);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(127, 33);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(707, 42);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 33);
            this.comboBox2.TabIndex = 14;
            // 
            // btnManageCars
            // 
            this.btnManageCars.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageCars.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageCars.FlatAppearance.BorderSize = 0;
            this.btnManageCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCars.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageCars.Location = new System.Drawing.Point(467, 33);
            this.btnManageCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(146, 45);
            this.btnManageCars.TabIndex = 12;
            this.btnManageCars.Text = "Manage Cars";
            this.btnManageCars.UseVisualStyleBackColor = false;
            this.btnManageCars.Click += new System.EventHandler(this.ManageCars);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageBookings.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageBookings.FlatAppearance.BorderSize = 0;
            this.btnManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageBookings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageBookings.Location = new System.Drawing.Point(300, 33);
            this.btnManageBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(159, 45);
            this.btnManageBookings.TabIndex = 11;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = false;
            this.btnManageBookings.Click += new System.EventHandler(this.ManageBookings);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.SlateGray;
            this.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageUsers.Location = new System.Drawing.Point(150, 35);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(141, 45);
            this.btnManageUsers.TabIndex = 10;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.ManageUsers);
            // 
            // btnMyBookings
            // 
            this.btnMyBookings.BackColor = System.Drawing.Color.SlateGray;
            this.btnMyBookings.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnMyBookings.FlatAppearance.BorderSize = 0;
            this.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyBookings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMyBookings.Location = new System.Drawing.Point(4, 35);
            this.btnMyBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMyBookings.Name = "btnMyBookings";
            this.btnMyBookings.Size = new System.Drawing.Size(137, 45);
            this.btnMyBookings.TabIndex = 5;
            this.btnMyBookings.Text = "My Bookings";
            this.btnMyBookings.UseVisualStyleBackColor = false;
            this.btnMyBookings.Click += new System.EventHandler(this.LoadMyBookings);
            // 
            // panelFooterHome
            // 
            this.panelFooterHome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFooterHome.Location = new System.Drawing.Point(0, 868);
            this.panelFooterHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFooterHome.Name = "panelFooterHome";
            this.panelFooterHome.Size = new System.Drawing.Size(1241, 43);
            this.panelFooterHome.TabIndex = 6;
            // 
            // linkLabelHomeLogout
            // 
            this.linkLabelHomeLogout.AutoSize = true;
            this.linkLabelHomeLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelHomeLogout.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelHomeLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelHomeLogout.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelHomeLogout.Location = new System.Drawing.Point(1151, 18);
            this.linkLabelHomeLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelHomeLogout.Name = "linkLabelHomeLogout";
            this.linkLabelHomeLogout.Size = new System.Drawing.Size(94, 29);
            this.linkLabelHomeLogout.TabIndex = 12;
            this.linkLabelHomeLogout.TabStop = true;
            this.linkLabelHomeLogout.Text = "Logout";
            this.linkLabelHomeLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout);
            // 
            // linkLabelGoBack
            // 
            this.linkLabelGoBack.AutoSize = true;
            this.linkLabelGoBack.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabelGoBack.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGoBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabelGoBack.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelGoBack.Location = new System.Drawing.Point(4, 18);
            this.linkLabelGoBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGoBack.Name = "linkLabelGoBack";
            this.linkLabelGoBack.Size = new System.Drawing.Size(67, 19);
            this.linkLabelGoBack.TabIndex = 13;
            this.linkLabelGoBack.TabStop = true;
            this.linkLabelGoBack.Text = "Go Back";
            this.linkLabelGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 912);
            this.Controls.Add(this.linkLabelGoBack);
            this.Controls.Add(this.linkLabelHomeLogout);
            this.Controls.Add(this.panelFooterHome);
            this.Controls.Add(this.panelLanding);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.dataGridAllCars);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllCars)).EndInit();
            this.panelLanding.ResumeLayout(false);
            this.panelLanding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAllCars;
        public System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLanding;
        private System.Windows.Forms.Panel panelFooterHome;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.LinkLabel linkLabelHomeLogout;
        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.LinkLabel linkLabelGoBack;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelHomeCarModel;
        private System.Windows.Forms.Label labelHomeCarMake;
        private System.Windows.Forms.Button btnHomeFilter;
        private System.Windows.Forms.Button buttonReviews;
    }
}