using AutoMapper;
using MotorLease.Data.Dtos;
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
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Services;
using MotorLease.Data.Dtos.Models;

namespace MotorLease.Client.Forms
{
    public partial class MyBookings : Form
    {
        FormClosingEventArgs formClosingEventArgs;

        private CarBooking bookingForm;

        private EventArgs eventArgs;


        private readonly IBookingService bookingService;
        private readonly ICarService motorService;
        private readonly IReviewService reviewService;

        List<BookingGridResponse> gridUserBooking = new List<BookingGridResponse>();
        List<BookingGridResponse> gridUserBooking2 = new List<BookingGridResponse>();

        DataGridViewButtonColumn editBooking = new DataGridViewButtonColumn();
        DataGridViewButtonColumn cancelBooking = new DataGridViewButtonColumn();
        DataGridViewButtonColumn reviewBooking = new DataGridViewButtonColumn();

        Image image = null;
        MessageBox messageBox;

        public MyBookings()
        {
            bookingService = Program.GetService<IBookingService>();
            motorService = Program.GetService<ICarService>();
            reviewService = Program.GetService<IReviewService>();   
            InitializeComponent();
        }

        public void MyBookings_Load(object sender, EventArgs e)
        {
            Form home = new Home();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = home;

            lblLanding.Text = ApplicationInfo.WelcomeMessage;
            LoadUserBookingsById();
        }

        public async void dataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridResponse, BookingGridRequest>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();


            if (dataGridViewMyBookings.Columns[e.ColumnIndex].Name == "editBooking")
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
            if (dataGridViewMyBookings.Columns[e.ColumnIndex].Name == "cancelBooking")
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
                        MyBookings_Load(sender, eventArgs);
                        Show();

                        ApplicationInfo.CancelBookingCarModelId = result.CarModelId;
                    }
                }
                else
                {

                }
                
                return;
            }
            if (dataGridViewMyBookings.Columns[e.ColumnIndex].Name == "reviewBooking")
            {
                if (MessageBox.Show("Thank you for choosing add to a review. We do appreciate your feedback!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        ApplicationInfo.BookingId = result.Id;
                        ReviewBooking(result);
                    }
                }
                else
                {

                }
                
                return;
            }

            MyBookings_Load(sender, eventArgs);

        }

        public void LoadUserBookingsById()
        {
            var userBookings = bookingService.GetBookingsById();
            foreach (var listItem in userBookings)
            {
                var result = new BookingGridResponse
                {
                    Id = listItem.Id,
                    UserId = listItem.UserId,
                    CustomerName = listItem.CustomerName,
                    CarModelId = listItem.CarModelId,
                    Make = listItem.Make,
                    Model = listItem.Model,
                    Image = listItem.Image,
                    DateFrom = listItem.DateFrom,
                    DateTo = listItem.DateTo,
                    TotalPrice = listItem.TotalPrice
                };

                gridUserBooking2.Add(result);
            }

            DefineLandingFormDataGrid(dataGridViewMyBookings);
            dataGridViewMyBookings.DataSource = userBookings;
            AddExtraColumnsUserBookingsFormGrid(dataGridViewMyBookings);

            dataGridViewMyBookings.Columns["Id"].Visible = false;
            dataGridViewMyBookings.Columns["UserId"].Visible = false;
            dataGridViewMyBookings.Columns["CarModelId"].Visible = false;

            ApplicationInfo.BookingGridResponses = userBookings;
            
        }

        public void EditBooking(BookingGridRequest editBookingRequest) 
        {
            var bookingForEdit = ApplicationInfo.BookingGridResponses.Where(bkr => bkr.Id == editBookingRequest.Id);
            if (bookingForEdit != null)
            {
                int EditBookingId = ApplicationInfo.BookingId;
                int EditBookingCarModelId = ApplicationInfo.CarModelId;
                ApplicationInfo.BookingForEdit = bookingForEdit.Where(bfe=>bfe.Id == EditBookingId).FirstOrDefault();

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

        public void ReviewBooking(BookingGridRequest editBookingRequest)
        {
            
            var bookingForReview = ApplicationInfo.BookingGridResponses.Where(bkr => bkr.Id == editBookingRequest.Id);
            if (bookingForReview != null)
            {
                int EditBookingId = ApplicationInfo.BookingId;
                int EditBookingCarModelId = ApplicationInfo.CarModelId;
                ApplicationInfo.BookingForReview = bookingForReview.Where(bfe => bfe.Id == EditBookingId).FirstOrDefault();

                Form addReview = new AddReview();
                Hide();
                addReview.Show();

                //int bookingId = editBookingRequest.Id;

                //var reviewRequest = new CreateReviewRequest
                //{
                //    BookingId = bookingId,
                //    UserId = ApplicationInfo.UserId,
                //    Comments = ApplicationInfo.Comments,
                //};

                //var resp = reviewService.AddReview(reviewRequest);
                //if (resp > 0)
                //{
                //    MessageBox.Show("Thank you for choosing Lawi Rides.. We would be happy to see you again.");
                //    return true;
                //}

            }

        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.Logout();
        }

        private void Filter(object sender, EventArgs e)
        {

        }

        #region UserBooking Grid

        public DataGridView AddExtraColumnsUserBookingsFormGrid(DataGridView dataGridView)
        {
            if (!dataGridView.Columns.Contains("editBooking") || !dataGridView.Columns.Contains("cancelBooking") || !dataGridView.Columns.Contains("reviewBooking"))
            {
                dataGridView.Columns.Add(GenerateMyBookingsAddReviewButtonColumn(reviewBooking));
                dataGridView.Columns.Add(GenerateMyBookingsEditButtonColumn(editBooking));
                dataGridView.Columns.Add(GenerateMyBookingsCancelButtonColumn(cancelBooking));
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

        public DataGridViewImageColumn GenerateMyBookingsImageColumn(DataGridViewImageColumn column)
        {
            column.Image = image;
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            column.HeaderText = "Image";
            column.Name = "img";

            return column;
        }

        public DataGridViewButtonColumn GenerateMyBookingsEditButtonColumn(DataGridViewButtonColumn column)
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

        public DataGridViewButtonColumn GenerateMyBookingsCancelButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Cancel";
            column.Name = "cancelBooking";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 80;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column; 
        }

        public DataGridViewButtonColumn GenerateMyBookingsAddReviewButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Add Review";
            column.Name = "reviewBooking";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 90;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }




        #endregion

        
    }
}
