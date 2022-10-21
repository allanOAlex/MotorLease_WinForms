using AutoMapper;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class ManageBookings : Form
    {
        private readonly IBookingService bookingService;
        List<BookingGridResponse> gridBookings = new List<BookingGridResponse>();
        DataGridViewButtonColumn editBooking = new DataGridViewButtonColumn();
        DataGridViewButtonColumn deleteBooking = new DataGridViewButtonColumn();

        private MyBookings myBookings;

        Image image;
        public ManageBookings(MyBookings MyBookings)
        {
            bookingService = Program.GetService<IBookingService>();
            myBookings = MyBookings;
            InitializeComponent();
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            lblLanding.Text = ApplicationInfo.WelcomeMessage;
            LoadUserBookings();
        }

        public void LoadUserBookings()
        {
            var bookings = bookingService.GetBookings();
            List<Booking> userBookingList = bookings.ToList();

            var bookingResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingGridResponse>());
            IMapper bookingResponseMapper = bookingResponseMap.CreateMapper();

            if (userBookingList.Count == 0)
            {
                var emptyResults = new BookingGridResponse
                {
                    MakeDescription = "No Records",
                    ModelDescription = "No Records",
                    Image = image,
                    DateFrom = DateTime.Today,
                    DateTo = DateTime.Today
                };

                gridBookings.Add(emptyResults);
                return;
            }

            foreach (var listItem in userBookingList)
            {
                var result = bookingResponseMapper.Map<Booking, BookingGridResponse>(listItem);

                result = new BookingGridResponse
                {
                    MakeDescription = ApplicationInfo.CarMakeDescription,
                    ModelDescription = ApplicationInfo.CarModelDescription,
                    Image = image,
                    DateFrom = ApplicationInfo.DateFrom,
                    DateTo = ApplicationInfo.DateTo
                };

                gridBookings.Add(result);
            }

            

            DefineLandingFormDataGrid(dataGridAllBookings);
            dataGridAllBookings.DataSource = gridBookings;
            AddExtraColumnsManageBookingsFormGrid(dataGridAllBookings);
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Form register = new CreateUser();
            register.Show();
        }

        public DataGridView AddExtraColumnsManageBookingsFormGrid(DataGridView dataGridView)
        {
            if (!dataGridView.Columns.Contains("editBooking") || !dataGridView.Columns.Contains("cancelBooking") || !dataGridView.Columns.Contains("reviewBooking"))
            {
                dataGridView.Columns.Add(GenerateManageBookingsEditButtonColumn(editBooking));
                dataGridView.Columns.Add(GenerateManageBookingsDeleteButtonColumn(deleteBooking));
            }
            else
            {
                //Do absolutley nothing, life continues;
            }

            return dataGridView;
        }

        public DataGridView DefineLandingFormDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridView.AutoResizeColumns();

            return dataGridView;
        }

        public DataGridViewImageColumn GenerateManageBookingsImageColumn(DataGridViewImageColumn column)
        {
            column.Image = image;
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            column.HeaderText = "Image";
            column.Name = "img";

            return column;
        }

        public DataGridViewButtonColumn GenerateManageBookingsEditButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Edit";
            column.Name = "editBooking";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }

        public DataGridViewButtonColumn GenerateManageBookingsDeleteButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Delete";
            column.Name = "deleteBooking";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }


    }
}
