using AutoMapper;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class ManageBookings : Form
    {
        private readonly IBookingService bookingService;
        private readonly ICarService carService;

        private EventArgs eventArgs;


        List<BookingGridResponse> gridBookings = new List<BookingGridResponse>();
        DataGridViewButtonColumn editBooking = new DataGridViewButtonColumn();
        DataGridViewButtonColumn cancelBooking = new DataGridViewButtonColumn();

        private MyBookings myBookings;

        Image image;
        public ManageBookings(MyBookings MyBookings)
        {
            bookingService = Program.GetService<IBookingService>();
            carService = Program.GetService<ICarService>();
            myBookings = MyBookings;
            InitializeComponent();
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            Form home = new Home();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = home;

            lblLanding.Text = ApplicationInfo.WelcomeMessage;
            GetBookings();
        }

        public void GetBookings()
        {
            var bookings = bookingService.GetAdminBookings();
            List<BookingGridResponse> userBookingList = bookings.ToList();
            ApplicationInfo.BookingGridResponses = userBookingList;

            var bookingResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingGridResponse>());
            IMapper bookingResponseMapper = bookingResponseMap.CreateMapper();

            if (userBookingList.Count == 0)
            {
                var emptyResults = new BookingGridResponse
                {
                    Make = "No Records",
                    Model = "No Records",
                    Image = image,
                    DateFrom = DateTime.Today,
                    DateTo = DateTime.Today
                };

                gridBookings.Add(emptyResults);
                return;
            }

            foreach (var listItem in userBookingList)
            {
                //var result = bookingResponseMapper.Map<Booking, BookingGridResponse>(listItem);
                var result = new BookingGridResponse
                {
                    Id =listItem.Id,
                    UserId = listItem.UserId,
                    CustomerName = listItem.CustomerName,
                    CarModelId = listItem.CarModelId,
                    Make = listItem.Make,
                    Model = listItem.Model,
                    Image = listItem.Image,
                    DateFrom = listItem.DateFrom,
                    DateTo = listItem.DateTo,
                    TotalPrice = listItem.TotalPrice,   
                };

                gridBookings.Add(result);
            }

            DefineLandingFormDataGrid(dataGridAllBookings);
            dataGridAllBookings.DataSource = gridBookings;
            AddExtraColumnsManageBookingsFormGrid(dataGridAllBookings);

            dataGridAllBookings.Columns["Id"].Visible = false;
            dataGridAllBookings.Columns["UserId"].Visible = false;
            dataGridAllBookings.Columns["CarModelId"].Visible = false;
        }

        private void CreateNewBooking(object sender, EventArgs e)
        {
            Form createBooking = new CreateBooking();
            createBooking.Show();
            Hide();
            //Close();
        }

        public DataGridView AddExtraColumnsManageBookingsFormGrid(DataGridView dataGridView)
        {
            if (!dataGridView.Columns.Contains("editBooking") || !dataGridView.Columns.Contains("cancelBooking"))
            {
                dataGridView.Columns.Add(GenerateManageBookingsEditButtonColumn(editBooking));
                dataGridView.Columns.Add(GenerateManageBookingsCancelButtonColumn(cancelBooking));
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

        public DataGridViewButtonColumn GenerateManageBookingsCancelButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Cancel";
            column.Name = "cancelBooking";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.Logout();
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);

        }

        private void Filter(object sender, EventArgs e)
        {

        }

        private void dataGridAllBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridResponse, BookingGridRequest>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();


            if (dataGridAllBookings.Columns[e.ColumnIndex].Name == "editBooking")
            {
                if (MessageBox.Show("Are you sure want to edit this booking ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var grid = (DataGridView)sender;

                    if (e.RowIndex < 0)
                    {
                        return;
                    }

                    if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                    {
                        var bookButtonClicked = (Action<BookingGridResponse>)grid.Columns[e.ColumnIndex].Tag;
                        var booking = (BookingGridResponse)grid.Rows[e.RowIndex].DataBoundItem;
                        var result = ResponseMapper.Map<BookingGridResponse, BookingGridRequest>(booking);

                        ApplicationInfo.BookingId = booking.Id;
                        ApplicationInfo.CarModelId = booking.CarModelId;
                        EditBooking(result);
                    }

                }
                else
                {

                }

                return;
            }
            if (dataGridAllBookings.Columns[e.ColumnIndex].Name == "cancelBooking")
            {
                if (MessageBox.Show("Are you sure want to cancel this booking ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var grid = (DataGridView)sender;

                    if (e.RowIndex < 0)
                    {
                        return;
                    }

                    if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                    {
                        var bookButtonClicked = (Action<BookingGridResponse>)grid.Columns[e.ColumnIndex].Tag;
                        var booking = (BookingGridResponse)grid.Rows[e.RowIndex].DataBoundItem;
                        var result = ResponseMapper.Map<BookingGridResponse, BookingGridRequest>(booking);
                        DoCancelBooking(result);
                        Hide();
                        ManageBookings_Load(sender, eventArgs);
                        //MyBookings myBookings = new MyBookings();
                        //myBookings.MyBookings_Load(sender, eventArgs);
                        Show();

                        ApplicationInfo.CancelBookingCarModelId = result.CarModelId;
                    }
                }
                else
                {

                }

                return;
            }
            
        }

        public void EditBooking(BookingGridRequest editBookingRequest)
        {
            var bookingForEdit = ApplicationInfo.BookingGridResponses.Where(bkr => bkr.Id == editBookingRequest.Id);
            if (bookingForEdit != null)
            {
                int EditBookingId = ApplicationInfo.BookingId;
                int EditBookingCarModelId = ApplicationInfo.CarModelId;
                ApplicationInfo.ReavailForBooking = ApplicationInfo.CarModelId;
                ApplicationInfo.BookingForEdit = bookingForEdit.Where(bfe => bfe.Id == EditBookingId).FirstOrDefault();

                Form editUserBooking = new EditBooking();
                Hide();
                editUserBooking.Show();

            }

        }

        public bool DoCancelBooking(BookingGridRequest editBookingRequest)
        {
            var bookingForEdit = ApplicationInfo.BookingGridResponses.Where(bkr => bkr.Id == editBookingRequest.Id);
            if (bookingForEdit != null)
            {
                int EditBookingId = ApplicationInfo.CarModelId;
                ApplicationInfo.BookingForCancel = bookingForEdit.Where(bfe => bfe.Id == EditBookingId).FirstOrDefault();

                //EditBooking editBooking = new EditBooking();
                //Form cancelBooking = new CancelBooking(editBooking);
                //cancelBooking.Show();

                int bookingId = editBookingRequest.Id;
                int carModelId = editBookingRequest.CarModelId;
                var resp = bookingService.CancelBooking(bookingId, carModelId);
                if (resp > 0)
                {
                    MessageBox.Show("Booking cancelled successfully.");
                    //Close();
                    Hide();
                    Show();
                    return true;
                }

                return true;
            }
            return false;
        }

    }
}
