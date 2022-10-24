using MotorLease.Data.Dtos.Models;
using MotorLease.Data.Interfaces;
using MotorLease.Data.Services;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class CreateBooking : Form
    {
        private readonly IBookingService bookingService;
        private readonly ICarService carService;
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserService userService;

        List<CarMake> carMakes = new List<CarMake>();
        List<CarModel> carModels = new List<CarModel>();

        
        public static int UserId { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int CarModelId { get; set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }

        public CreateBooking()
        {
            bookingService = Program.GetService<IBookingService>();
            carService = Program.GetService<ICarService>();
            userService = Program.GetService<IUserService>();
            unitOfWork = Program.GetService<IUnitOfWork>();

            InitializeComponent();
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
            MyBookings myBookings = new MyBookings();
            Form previous = new ManageBookings(myBookings);
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = previous;

            GetMakeComboBoxData();
            GetModelComboBoxData();

            comboBoxMake.DataSource = carMakeBindingSource;
            comboBoxMake.DisplayMember = "Description";
            comboBoxMake.ValueMember = "Id";

            comboBoxModel.DataSource = carModelBindingSource;
            comboBoxModel.DisplayMember = "Description";
            comboBoxModel.ValueMember = "Id";


            //UserId = ApplicationInfo.UserId;
            CarModelId = ApplicationInfo.CarModelId;
            //UnitPrice = //get from the grid
            //TotalPrice = //calculate
            //BookingDate = DateTime.Today
            //CreatedBy = ApplicationInfo.UserId  

            Make_SelectedIndexChanged(sender, e);
        }

        private void Save(object sender, EventArgs e)
        {
            DoBooking(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        public async void DoBooking(DateTime from, DateTime to)
        {
            AppExtension.ValidateBookingDates(from, to);

            await DoCreateBooking();
            Close();
            MyBookings myBookings = new MyBookings();
            Form manageBookings = new ManageBookings(myBookings);
            manageBookings.Show();


        }

        private async Task<CreateBookingResponse> DoCreateBooking()
        {
            //TotalPrice = AppExtension.GetTotalPrice(dateTimePickerFrom.Value, dateTimePickerTo.Value, UnitPrice);

            var bookingRequest = new CreateBookingRequest
            {
                UserId = ApplicationInfo.UserId,
                CarModelId = ApplicationInfo.CarModelId,
                UnitPrice = UnitPrice,
                TotalPrice = AppExtension.GetTotalPrice(dateTimePickerFrom.Value, dateTimePickerTo.Value, UnitPrice),
                BookingDate = DateTime.Now,
                CreatedBy = ApplicationInfo.UserId,
                DateFrom = dateTimePickerFrom.Value,
                DateTo = dateTimePickerTo.Value,
                UpdatedBy = ApplicationInfo.UserId
            };

            try
            {
                var createdBooking = await bookingService.CreateBooking(bookingRequest);
                if (createdBooking != null)
                {
                    ApplicationInfo.CreateBookingResponse = createdBooking;

                    int available = carService.RemoveAvailability();
                    if (available > 0)
                    {
                        await unitOfWork.CompleteAsync();
                    }

                    MessageBox.Show($"Booking created successfully");
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

        public List<CarMake> GetMakeComboBoxData()
        {

            carMakes = carService.GetMakeComboBoxData();
            carMakeBindingSource.DataSource = carMakes;
            return carMakes;
        }

        public List<CarModel> GetModelComboBoxData()
        {
            carModels = carService.GetModelComboBoxData();
            carModelBindingSource.DataSource = carModels;
            return carModels;
        }

        public decimal GetUnitPrice(int carModelId)
        {
            var unitPrice = carService.GetUnitPrice(carModelId);
            return unitPrice;
        }


        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.Logout();
        }

        private void Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMake.SelectedIndex;

            if (comboBoxMake.SelectedValue != null)
            {
                int selectedValue = (int)comboBoxMake.SelectedValue;
                var makeModels = carModels.Where(m => m.CarMakeId == selectedValue).ToList();
                comboBoxModel.DataSource = makeModels;
            }
            else
            {
                // Do Absolutely Nothing
            }
        }

        private void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedValue != null)
            {
                comboBoxModel.SelectedValue = (int)comboBoxModel.SelectedValue;
                ApplicationInfo.CarModelId = (int)comboBoxModel.SelectedValue;
            }
            else
            {
                // Do Absolutely Nothing
            }
            var price = GetUnitPrice((int)comboBoxModel.SelectedValue).ToString();
            UnitPrice = GetUnitPrice((int)comboBoxModel.SelectedValue);
            labelUnitPrice.Text = price;
        }

        private void AbortBooking(object sender, EventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);
        }

        private async void SearchUser(object sender, EventArgs e)
        {
            var request = new GetUserByIdRequest
            {
                IdNumber = textBoxIdNo.Text
            };

            var user = await GetUserByIdNumber(request);

            UserId = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;

            labelCustomerName.Text = FirstName + " " + LastName;
        }
            

        public async Task<GetUserByIdResponse> GetUserByIdNumber(GetUserByIdRequest request)
        {
            request.IdNumber = textBoxIdNo.Text;
            var user = await userService.GetUserByIdNumber(request);
            return user;
        }
    }
}
