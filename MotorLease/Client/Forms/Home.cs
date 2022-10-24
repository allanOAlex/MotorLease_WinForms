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
        FormClosingEventArgs formClosingEventArgs;
        private readonly ICarService motorService;
        private readonly IBookingService bookingService;

        GridImage gridImage = new GridImage();

        DataGridViewButtonColumn bookButton = new DataGridViewButtonColumn();
        DataGridViewImageColumn img = new DataGridViewImageColumn();
        DataTable dataTable = new DataTable();
        List<CarModel> gridList = new List<CarModel>();
        List<MotorModelGridResposne> gridMotorList = new List<MotorModelGridResposne>();
        List<CarModelGridResponse> gridMotorList2 = new List<CarModelGridResponse>();
        List<GridImage> gridImages = new List<GridImage>();



        public static int Id { get; set; }
        public static int UserId { get; set; }
        public static string Message { get; set; }

        Image image = null;

        public Home()
        {
            motorService = Program.GetService<ICarService>();
            bookingService = Program.GetService<IBookingService>();

            InitializeComponent();
        }

        //Method that is called when the form loads, and passes data to the form
        private void LandingPage_Load(object sender, EventArgs e)
        {
            ApplicationInfo.PreviousForm = this;
            ApplicationInfo.CurrentForm = this;

            linkLabelGoBack.Visible = false;
            lblHome.Text = Message;
            btnMyBookings.Visible = true;
            

            if (ApplicationInfo.IsAdmin == false)
            {
                btnManageUsers.Visible = false;
                btnManageBookings.Visible = false;
                btnManageCars.Visible = false;
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
            Hide();
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
                var bookButtonClicked = (Action<CarModelGridResponse>)grid.Columns[e.ColumnIndex].Tag;
                var motor = (CarModelGridResponse)grid.Rows[e.RowIndex].DataBoundItem;

                //Could be used at Manage Bookings
                //ApplicationInfo.CarUnitPrice = 0;
                //ApplicationInfo.TotalPrice = 0;
                //ApplicationInfo.BookingDate = DateTime.Now;

                Hide();
                DoBooking(motor);
            }

        }

        public void DoBooking(CarModelGridResponse model)
        {

            MyBookings myBookings = new MyBookings();
            MessageBox.Show($"Booking {model.Make} {model.Model} {model.Registration}");
            Form bookingForm = new CarBooking(myBookings);

            ApplicationInfo.CarModelId = model.Id;
            ApplicationInfo.CarMakeDescription = model.Make;
            ApplicationInfo.CarUnitPrice = model.UnitPrice;

            Hide();
            bookingForm.Show();
        }

        public IQueryable<CarModel> GetCar(CarModel request)
        {
            try
            {
                var car = motorService.GetCar(request);
                if (car != null)
                {
                    return car;
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
            var motors = motorService.GetCarModelsForHome();
            List<CarModelGridResponse> motorList = motors.ToList();

            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<CarModel, CarModelGridResponse>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();

            var ImageResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<CarModelGridResponse, MotorModelGridResposne>());
            IMapper ImageResponseMapper = ImageResponseMap.CreateMapper();

            foreach (var listItem in motorList)
            {
                gridImage.CarModelId = listItem.Id;
                gridImage.Image = image;
                gridImages.Add(gridImage);

                var result = new CarModelGridResponse
                {
                    Id = listItem.Id,
                    Make = listItem.Make,
                    Model = listItem.Model,
                    Registration = listItem.Registration,
                    UnitPrice = listItem.UnitPrice,
                    Image = listItem.Image,

                };
                gridMotorList2.Add(result);

                var list = motorList.Select(m => new
                {
                    m.Id,
                    m.Model,
                    m.Image,
                    m.Registration,
                    m.UnitPrice,

                });
            }

            
            DefineLandingFormDataGrid(dataGridAllCars);
            dataGridAllCars.DataSource = gridMotorList2;
            AddExtraColumnsToLandingFormGrid(dataGridAllCars);
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
            dataGridView.Tag = (Action<CarModelGridResponse>)DoBooking;

            return dataGridView;
        }

        public DataGridView AddExtraColumnsToLandingFormGrid(DataGridView dataGridView)
        {
            //dataGridView.Columns.Add(GenerateLandingPageImageColumn(img));
            dataGridView.Columns.Add(GenerateLandingPageBookButtonColumn(bookButton));

            return dataGridView;
        }

        #endregion


        public void DeleteRow(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridAllCars.Columns[e.ColumnIndex].Name == "Book")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridMotorList.RemoveAt(e.RowIndex);
                }

            }
        }

        private void ManageBookings(object sender, EventArgs e)
        {
            MyBookings myBookings = new MyBookings();
            Form manageBookings = new ManageBookings(myBookings);
            manageBookings.Show();
        }

        private void ManageUsers(object sender, EventArgs e)
        {
            Hide();
            Form manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void ManageCars(object sender, EventArgs e)
        {
            Hide();
            Form manageCars = new ManageCars();
            manageCars.Show();
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AppExtension.Logout(sender, formClosingEventArgs);
            AppExtension.Logout();
        }

        private void Filter(object sender, EventArgs e)
        {
            //var request = new SearchCarRequest
            //{
            //    MakeId = 0,
            //    ModelId = 0
            //};

            //var user = await GetUserByIdNumber(request);

            //UserId = user.Id;
            //FirstName = user.FirstName;
            //LastName = user.LastName;

            //labelCustomerName.Text = FirstName + " " + LastName;
        }

        private void GetUserReviews(object sender, EventArgs e)
        {
            Form reviews = new UserReviews();
            reviews.Show(); 
        }
    }
}
