using AutoMapper;
using MotorLease.Data.Dtos.Forms;
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
    public partial class UserReviews : Form
    {
        private readonly IReviewService reviewService;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        List<Review> reviewsList = new List<Review>();
        List<ReviewGridResponse> reviewGridResponses = new List<ReviewGridResponse>();
        List<ReviewGridResponse> dataGridResponse = new List<ReviewGridResponse>();

        public UserReviews()
        {
            reviewService = Program.GetService<IReviewService>();
            unitOfWork = Program.GetService<IUnitOfWork>();
            InitializeComponent();
        }

        private async void UserReviews_Load(object sender, EventArgs e)
        {
            lblUserReviews.Text = $"We love to know how our customers feel. Thank you, and Welcome!";
            Form home = new Home();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = home;

            reviewsList = await GetReviews();
            reviewGridResponses = await GetUserReviews();
            foreach (var review in reviewGridResponses)
            {
                var reviewGridResponse = new ReviewGridResponse
                {
                    Make = review.Make, 
                    Model= review.Model,    
                    Comments=review.Comments,
                    Customer = review.Customer
                };

                dataGridResponse.Add(reviewGridResponse);
            }

            DefineLandingFormDataGrid(dataGridViewUserReviews);
            dataGridViewUserReviews.DataSource = reviewGridResponses;
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.GoBack(ApplicationInfo.CurrentForm, ApplicationInfo.PreviousForm);
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.Logout();
        }

        public async Task<List<Review>> GetReviews()
        {
            var reviews = reviewService.GetReviews().ToList();
            return reviews;
        }

        public async Task<List<ReviewGridResponse>> GetUserReviews()
        {
            var reviews = reviewService.GetUserReviews();
            return reviews;
        }

        public DataGridView DefineLandingFormDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 50;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            return dataGridView;
        }
    }
}
