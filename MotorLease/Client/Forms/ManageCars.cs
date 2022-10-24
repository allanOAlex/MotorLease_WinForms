using AutoMapper;
using MotorLease.Data.Dtos.Forms;
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
//using static System.Net.Mime.MediaTypeNames;

namespace MotorLease.Client.Forms
{
    public partial class ManageCars : Form
    {

        private readonly IBookingService bookingService;
        private readonly ICarService carService;
        private readonly IUnitOfWork unitOfWork;

        List<CarModelGridResponse> carModelGridResponses = new List<CarModelGridResponse>();

        public static int CarModelId { get; set; }

        Image image = null;

        public ManageCars()
        {
            bookingService = Program.GetService<IBookingService>();
            carService = Program.GetService<ICarService>();
            unitOfWork = Program.GetService<IUnitOfWork>();
            InitializeComponent();
        }

        private void ManageCars_Load(object sender, EventArgs e)
        {
            Form home = new Home();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = home;

            LoadCarModels();
        }

        private void dataGridManageCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        public void LoadCarModels()
        {
            var motors = carService.GetCarModels2();
            List<CarModelGridResponse> motorList = motors.ToList();

            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<CarModel, CarModelGridResponse>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();

            foreach (var listItem in motorList)
            {
                var result = new CarModelGridResponse
                {
                    Id = listItem.Id,
                    Make = listItem.Make,
                    Model = listItem.Model,
                    Registration = listItem.Registration,
                    UnitPrice = listItem.UnitPrice,
                    Image = listItem.Image,

                };
                carModelGridResponses.Add(result);

            }

            DefineLandingFormDataGrid(dataGridManageCars);
            dataGridManageCars.DataSource = carModelGridResponses;

        }

        public DataGridView DefineLandingFormDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 70;
            dataGridView.AllowUserToAddRows = false;

            return dataGridView;
        }


    }
}
