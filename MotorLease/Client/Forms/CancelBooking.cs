using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class CancelBooking : Form
    {

        private readonly IBookingService bookingService;
        EditBooking editBooking;
        CarBooking carBooking;

        public CancelBooking(EditBooking EditBooking)
        {
            bookingService = Program.GetService<IBookingService>();
            editBooking = EditBooking;
            InitializeComponent();
        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {
            comboBoxMakeCancelBooking.DataSource = carMakeBindingSource;
            comboBoxMakeCancelBooking.DisplayMember = "Description";
            comboBoxMakeCancelBooking.ValueMember = "Id";

            comboBoxModelCancelBooking.DataSource = carModelBindingSource;
            comboBoxModelCancelBooking.DisplayMember = "Description";
            comboBoxModelCancelBooking.ValueMember = "Id";


            pictureBox1.Image = EditBooking.BookingForEdit.Image;
            comboBoxMakeCancelBooking.Text = EditBooking.BookingForEdit.Make;
            comboBoxModelCancelBooking.Text = EditBooking.BookingForEdit.Model;
            dateTimePickerFromCancelBooking.Value = EditBooking.BookingForEdit.DateFrom;
            dateTimePickerToCancelBooking.Value = EditBooking.BookingForEdit.DateTo;
        }

        private void Cancel(object sender, EventArgs e)
        {
            try
            {
                editBooking.CancelBooking();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            MessageBox.Show("Booking successfully cancelled");
           
        }

        


    }
}
