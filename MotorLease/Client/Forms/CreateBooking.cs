using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
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
    public partial class CreateBooking : Form
    {
        private DataGridViewCellEventArgs cellEvent;
        private object senderParam;
        private readonly IBookingService bookingService;
        private readonly ICarService motorService;

        private Home landingPageForm;
        private MyBookings myBookings;

        public static int MotorModelId { get; set; }
        public CreateBooking(MyBookings MyBookings)
        {
            bookingService = Program.GetService<IBookingService>();
            motorService = Program.GetService<ICarService>();
            myBookings = MyBookings;
            InitializeComponent();
        }

        private void AbortBooking(object sender, EventArgs e)
        {
            CreateBooking bookingFrom = new CreateBooking(myBookings);
            bookingFrom.Close();
            Form landing = new Home(bookingFrom);
            landing.Show();
        }

        private void PerformBooking(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            ApplicationInfo.DateFrom = from;
            ApplicationInfo.DateTo = to;


            ValidateBookingInfo(from, to);

            
        }

        private async Task<CreateBookingResponse> DoCreateBooking()
        {
            var bookingRequest = new CreateBookingRequest
            {
                MotorModelId = ApplicationInfo.CarModelId,
                UserId = ApplicationInfo.UserId,
                BookingDate = DateTime.Now,
                DateFrom = ApplicationInfo.DateFrom,
                DateTo = ApplicationInfo.DateTo
            };

            try
            {
                var createdBooking = await bookingService.CreateBooking(bookingRequest);
                if (createdBooking != null)
                {
                    CreateBooking bookingForm = new CreateBooking(myBookings);
                    bookingForm.Close();
                    ApplicationInfo.CreateBookingResponse = createdBooking;
                    motorService.RemoveAvailability();
                    Home landing = new Home(bookingForm);
                    if (landingPageForm == null)
                    {
                        landingPageForm = new Home(this);
                    }
                    landingPageForm.Hide();
                    landingPageForm.Show();

                    return createdBooking;
                }

                MessageBox.Show($"Failed Operation | Could not create booking");
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating user. | {ex.Message}");
            }

        }

        public async void ValidateBookingInfo(DateTime from, DateTime to)
        {
            if (from < DateTime.Today)
            {
                MessageBox.Show($"Collection date must be greater today");
                return;
            }
            if (to < DateTime.Today)
            {
                MessageBox.Show($"Return date must not be lesser than today");
                return;
            }
            if (from == to || to < from)
            {
                MessageBox.Show($"Return date must be greater than date of collection");
                return;
            }

            // await CreateBooking();
            await DoCreateBooking();
            //DataGridViewBookings_CellClick(senderParam, cellEvent);

            myBookings.Hide();
            myBookings.Refresh();
            myBookings.Show();

        }

        public void DataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myBookings.dataGridViewBookings_CellClick(sender, e);
        }
    }
}