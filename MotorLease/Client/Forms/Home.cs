using AutoMapper;
using MotorLease.Client.UserControls;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class Home : Form
    {
        private readonly ICarService motorService;
        private readonly IBookingService bookingService;
        private readonly CarModelRequest motorModelRequest;

        private CreateBooking bookingForm;
        

        DataGridViewButtonColumn bookButton = new DataGridViewButtonColumn();
        DataGridViewImageColumn img = new DataGridViewImageColumn();
        DataTable dataTable = new DataTable();
        List<CarModel> gridList = new List<CarModel>();
        List<MotorModelGridResposne> gridMotorList = new List<MotorModelGridResposne>();
        

        public static string Message { get; set; }
        public static int Id { get; set; }
        public static int UserId { get; set; }

        Image image = null;

        public Home(CreateBooking BookingForm)
        {
            motorService = Program.GetService<ICarService>();
            bookingService = Program.GetService<IBookingService>();

            bookingForm = BookingForm;

            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            lblLanding.Text = Message;
            btnMyBookings.Visible = true;
            

            if (ApplicationInfo.IsAdmin == false)
            {
                btnManageUsers.Visible = false;
                btnManageBookings.Visible = false;
            }

            dataTable.TableName = "AllCars";
            dataTable.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn("Name", typeof(string)),
                new DataColumn("Color", typeof(string)),
                new DataColumn("Registration", typeof(string)),
                new DataColumn("Price", typeof(decimal))
            });

            LoadMotorModels();
        }

        private void LoadMyBookings(object sender, EventArgs e)
        {
            Form myBookings = new MyBookings();
            myBookings.Show();
        }

        private void dataGridAllMotors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var bookButtonClicked = (Action<MotorModelGridResposne>)grid.Columns[e.ColumnIndex].Tag;
                var motor = (MotorModelGridResposne)grid.Rows[e.RowIndex].DataBoundItem;
                DoBooking(motor);
            }

        }

        public void DoBooking(MotorModelGridResposne model)
        {

            MyBookings myBookings = new MyBookings();
            MessageBox.Show($"Booking {model.Description} {model.Registration}");
            Form bookingForm = new CreateBooking(myBookings);
            ApplicationInfo.CarModelId = model.Id;
            CreateBooking.MotorModelId = Id;
            Hide();
            bookingForm.Show();
        }

        public async Task<CarModelResponse> GetMotors(CarModelRequest motorModelRequest)
        {
            try
            {
                var motors = await motorService.GetMotors(motorModelRequest);
                if (motors != null)
                {
                    return motors;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving records. | {ex.Message}");
            }
        }

        public void LoadMotorModels()
        {
            var motors = motorService.GetMotorModels();
            List<CarModel> motorList = motors.ToList();

            var motorModelResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<CarModel, MotorModelGridResposne>());
            IMapper motorModelResponseMapper = motorModelResponseMap.CreateMapper();

            foreach (var listItem in motorList)
            {
                Id = listItem.Id;
                image = AppExtension.ConvertBase64ToImage(listItem.Image);

                var result = motorModelResponseMapper.Map<CarModel, MotorModelGridResposne>(listItem);

                result = new MotorModelGridResposne
                {
                    Id = listItem.Id,
                    Description = listItem.Description,
                    Registration = listItem.Registration,
                    Price = listItem.UnitPrice,
                    Image = image,
                };

                gridMotorList.Add(result);

                var motorModel = new CarModel
                {
                    Description = listItem.Description,
                    Registration = listItem.Registration,
                    UnitPrice = listItem.UnitPrice
                };
                gridList.Add(motorModel);

                var list = motorList.Select(m => new
                {
                    m.Id,
                    m.Description,
                    m.Image,
                    m.Registration,
                    m.UnitPrice,
                    m.IsAvailable

                });
            }

            DefineLandingFormDataGrid(dataGridAllMotors);

            dataGridAllMotors.DataSource = gridMotorList;

            AddExtraColumnsToLandingFormGrid(dataGridAllMotors);
        }

        
        #region LandingPage Grid

        public DataGridViewButtonColumn GenerateLandingPageBookButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Book";
            column.Name = "bookButton";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }

        public DataGridViewImageColumn GenerateLandingPageImageColumn(DataGridViewImageColumn column)
        {
            column.Image = image;
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            column.HeaderText = "Image";
            column.Name = "img";

            return column;
        }

        public DataGridView DefineLandingFormDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Tag = (Action<MotorModelGridResposne>)DoBooking;

            return dataGridView;
        }

        public DataGridView AddExtraColumnsToLandingFormGrid(DataGridView dataGridView)
        {
            dataGridView.Columns.Add(GenerateLandingPageImageColumn(img));
            dataGridView.Columns.Add(GenerateLandingPageBookButtonColumn(bookButton));

            return dataGridView;
        }

        #endregion


        public void DeleteRow(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridAllMotors.Columns[e.ColumnIndex].Name == "Book")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridMotorList.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            MyBookings myBookings = new MyBookings();
            Form manageBookings = new ManageBookings(myBookings);
            manageBookings.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form manageUsers = new ManageUsers();
            manageUsers.Show();
        }
    }
}
