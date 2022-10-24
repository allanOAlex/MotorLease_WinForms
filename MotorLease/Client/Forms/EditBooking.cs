using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Data.Interfaces;
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
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class EditBooking : Form
    {

        private readonly ICarService carService;
        private readonly IBookingService bookingService;
        private readonly IUnitOfWork unitOfWork;

        public static BookingGridResponse BookingForEdit = new BookingGridResponse();
        List<CarMake> carMakes =new List<CarMake>(); 
        List<CarModel> carModels =new List<CarModel>();

        BookingGridResponse response = new BookingGridResponse();


        public EditBooking()
        {
            carService = Program.GetService<ICarService>();
            bookingService = Program.GetService<IBookingService>();
            unitOfWork = Program.GetService<IUnitOfWork>(); 
            InitializeComponent();
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            Form myBookings = new MyBookings();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = myBookings;

            BookingForEdit = ApplicationInfo.BookingForEdit;

            GetMakeComboBoxData();
            GetModelComboBoxData();

            comboBoxMakeEditBooking.DataSource = carMakeBindingSource;
            comboBoxMakeEditBooking.DisplayMember = "Description";
            comboBoxMakeEditBooking.ValueMember = "Id";

            comboBoxModelEditBooking.DataSource = carModelBindingSource;
            comboBoxModelEditBooking.DisplayMember = "Description";
            comboBoxModelEditBooking.ValueMember = "Id";


            pictureBox1.Image = BookingForEdit.Image;
            comboBoxMakeEditBooking.Text = BookingForEdit.Make;
            comboBoxModelEditBooking.Text = BookingForEdit.Model;
            dateTimePickerFromEditBooking.Value = BookingForEdit.DateFrom;
            dateTimePickerToEditBooking.Value = BookingForEdit.DateTo;

            MakeSelectedIndexChanged(sender, e);
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);

        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.Logout();
        }

        private async void Save(object sender, EventArgs e)
        {
            await DoEditBooking();
            MessageBox.Show("Booking saved successfully.");
            Form myBookings = new MyBookings();
            Close();
            myBookings.Show();
        }

        private void MakeSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMakeEditBooking.SelectedIndex;
            
            if (comboBoxMakeEditBooking.SelectedValue != null)
            {
                int selectedValue = (int)comboBoxMakeEditBooking.SelectedValue;
                var makeModels = carModels.Where(m => m.CarMakeId == selectedValue).ToList();
                comboBoxModelEditBooking.DataSource = makeModels;
            }
            else
            {
                // Do Absolutely Nothing
            }

        }

        private void ModelSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModelEditBooking.SelectedValue != null)
            {
                comboBoxModelEditBooking.SelectedValue = (int)comboBoxModelEditBooking.SelectedValue;
                ApplicationInfo.CarModelId = (int)comboBoxModelEditBooking.SelectedValue;
            }
            else
            {
                // Do Absolutely Nothing
            }
            
        }

        private void DateFromValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFromEditBooking.Value = dateTimePickerFromEditBooking.Value;
        }

        private void DateToValueChanged(object sender, EventArgs e)
        {
            dateTimePickerToEditBooking.Value = dateTimePickerToEditBooking.Value;
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

        public async Task<BookingGridResponse> DoEditBooking()
        {
            BookingGridRequest editBookingRequest = new BookingGridRequest();

            var carModel = carModels.Where(m => m.Id == ApplicationInfo.CarModelId).FirstOrDefault();

            ApplicationInfo.DateFrom = dateTimePickerFromEditBooking.Value;
            ApplicationInfo.DateTo = dateTimePickerToEditBooking.Value;
            ApplicationInfo.CarUnitPrice = carModel.UnitPrice;

            editBookingRequest.CarModelId = ApplicationInfo.CarModelId;
            editBookingRequest.UserId = ApplicationInfo.UserId;
            editBookingRequest.TotalPrice = 
                AppExtension.GetTotalPrice(ApplicationInfo.DateFrom, ApplicationInfo.DateTo, ApplicationInfo.CarUnitPrice);
            editBookingRequest.DateFrom = dateTimePickerFromEditBooking.Value;
            editBookingRequest.DateTo = dateTimePickerToEditBooking.Value;

            response = await bookingService.UpdateBooking(editBookingRequest);
            if (response != null)
            {
                return response;
                
            }
            return null;
        }

        public int CancelBooking()
        {
            int bookingId = ApplicationInfo.BookingId;
            int carModelId = ApplicationInfo.CarModelId;
            int response = bookingService.CancelBooking(bookingId, carModelId);

            return response;
        }
    }
}
