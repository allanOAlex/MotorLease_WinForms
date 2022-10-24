using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Interfaces;
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
    public partial class CarBooking : Form
    {
        
        private readonly IBookingService bookingService;
        private readonly ICarService carService;
        private readonly IUnitOfWork unitOfWork;

        private Home home;
        private MyBookings myBookings;
        private DateTime dateTo;
        private DateTime dateFrom;

        public Image image;
        public string imageString;

        public static int CarModelId { get; set; }
        public decimal unitPrice { get; private set; }

        public CarBooking(MyBookings MyBookings)
        {
            bookingService = Program.GetService<IBookingService>();
            carService = Program.GetService<ICarService>();
            unitOfWork = Program.GetService<IUnitOfWork>();
            myBookings = MyBookings;
            InitializeComponent();
        }

        private void CarBooking_Load(object sender, EventArgs e)
        {
            Form home = new Home();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = home;

            CarModelId = ApplicationInfo.CarModelId;
            image = GetCarImage();
            pictureBox1.Image = image;
        }

        private void AbortBooking(object sender, EventArgs e)
        {
            CarBooking bookingFrom = new CarBooking(myBookings);
            bookingFrom.Close();
            Form landing = new Home();
            landing.Show();
        }

        private void InitiateBooking(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            ApplicationInfo.DateFrom = from;
            ApplicationInfo.DateTo = to;

            DoBooking(from, to);
            
        }

        private async Task<CreateBookingResponse> DoCreateBooking()
        {
            var bookingRequest = new CreateBookingRequest
            {
                CarModelId = ApplicationInfo.CarModelId,
                UserId = ApplicationInfo.UserId,
                BookingDate = DateTime.Now,
                DateFrom = ApplicationInfo.DateFrom,
                DateTo = ApplicationInfo.DateTo,
                UnitPrice = ApplicationInfo.CarUnitPrice,
                TotalPrice = AppExtension.GetTotalPrice(dateTo, dateFrom, unitPrice),
                CreatedBy = ApplicationInfo.UserId,
                UpdatedBy = ApplicationInfo.UserId
            };

            try
            {
                var createdBooking = await bookingService.CreateBooking(bookingRequest);
                if (createdBooking != null)
                {
                    CarBooking bookingForm = new CarBooking(myBookings);
                    bookingForm.Close();
                    ApplicationInfo.CreateBookingResponse = createdBooking;
                    carService.RemoveAvailability();
                    if (home == null)
                    {
                        home = new Home();
                    }
                    home.Hide();
                    home.Show();

                    //await unitOfWork.CompleteAsync();

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

        public async void DoBooking(DateTime from, DateTime to)
        {
            AppExtension.ValidateBookingDates(from, to);
            
            await DoCreateBooking();

            myBookings.Hide();
            myBookings.Refresh();
            myBookings.Show();

        }

        public Image GetCarImage()
        {
            CarModel carModel = new CarModel();
            carModel.Id = CarModelId;
            imageString = carService.GetCarImage(carModel.Id);
            image = AppExtension.ConvertBase64ToImage(imageString); 
            return image;
        }

        public void DataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myBookings.dataGridViewBookings_CellClick(sender, e);
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);

        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}