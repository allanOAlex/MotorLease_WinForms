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

namespace MotorLease.Client.Forms
{
    public partial class MyBookings : Form
    {
        private CreateBooking bookingForm;

        private EventArgs eventArgs;

        private readonly IBookingService bookingService;
        private readonly ICarService motorService;

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
            InitializeComponent();
        }

        private void MyBookings_Load(object sender, EventArgs e)
        {
            lblLanding.Text = ApplicationInfo.WelcomeMessage;
            LoadUserBookingsById();
        }

        public async void dataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Form bookingform = new CreateBooking(this);

            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridResponse, BookingGridRequest>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();


            if (dataGridViewBookings.Columns[e.ColumnIndex].Name == "editBooking")
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

                        ApplicationInfo.CarModelId = booking.Id;
                        await EditBooking(result);
                    }

                }
                else
                {

                }
            }
            if (dataGridViewBookings.Columns[e.ColumnIndex].Name == "cancelBooking")
            {
                if (MessageBox.Show("Are you sure want to cancel this booking ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {

                }
            }


            if (dataGridViewBookings.Columns[e.ColumnIndex].Name == "reviewBooking")
            {
                if (MessageBox.Show("Thank you for choosing add a review. We do appreciate feedback like yours!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {

                }
            }

            
            bookingform.Show();
        }

        public void LoadUserBookingsById()
        {
            var userBookings = bookingService.GetBookingsById();
            foreach (var listItem in userBookings)
            {
                var result = new BookingGridResponse
                {
                    Id = listItem.Id,
                    MakeDescription = listItem.MakeDescription,
                    ModelDescription = listItem.ModelDescription,
                    Image = listItem.Image,
                    DateFrom = listItem.DateFrom,
                    DateTo = listItem.DateTo
                };

                gridUserBooking2.Add(result);
            }

            DefineLandingFormDataGrid(dataGridViewBookings);
            dataGridViewBookings.DataSource = userBookings;
            AddExtraColumnsUserBookingsFormGrid(dataGridViewBookings);
        }

        public async Task<BookingGridResponse> EditBooking(BookingGridRequest editBookingRequest)
        {
            Hide();
            


            var bookingForEdit = await bookingService.EditBooking(editBookingRequest);
            if (bookingForEdit != null)
            {
                Show();
                Refresh();
                
                return bookingForEdit;
            }

            return null;
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
            column.Width = 70;
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
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }



        #endregion

        
    }
}
