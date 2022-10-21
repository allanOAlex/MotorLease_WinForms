using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Client.UserControls
{
    public partial class BookingUserControl : UserControl
    {
        public static string Message { get; set; }

        public BookingUserControl()
        {
            InitializeComponent();
        }

        private void BookingUserControl_Load(object sender, EventArgs e)
        {
            lblBookingMsg.Text = $"Booking {ApplicationInfo.CarMakeDescription} {ApplicationInfo.CarModelDescription}";
        }
    }
}
