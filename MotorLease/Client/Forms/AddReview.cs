using AutoMapper;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class AddReview : Form
    {
        private readonly IReviewService reviewService;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public static string Comments { get; private set; } 

        public AddReview()
        {
            reviewService = Program.GetService<IReviewService>();
            unitOfWork = Program.GetService<IUnitOfWork>();
            InitializeComponent();
        }

        private void AddReview_Load(object sender, EventArgs e)
        {
            Form myBookings = new MyBookings();
            ApplicationInfo.CurrentForm = this;
            ApplicationInfo.PreviousForm = myBookings;
        }

        private async void SubmitReview(object sender, EventArgs e)
        {
            Comments = richTextBox1.Text;
            ApplicationInfo.Comments = Comments;
            await CreateReview();
            Form myBookings = new MyBookings();
            Close();
            myBookings.Show();

        }

        private async Task<Review>  CreateReview()
        {
            var createReviewRequest = new Review
            {
                UserId = ApplicationInfo.UserId,
                BookingId = ApplicationInfo.BookingId,
                Comments = richTextBox1.Text
            };

            try
            {
                //var createdReview = await reviewService.AddReview();
                var createdReview = reviewService.Create(createReviewRequest);
                if (createdReview != null)
                {
                    await unitOfWork.CompleteAsync();
                    MessageBox.Show($"Thank you for choosing Lawi Rides.. We would be happy to see you again.");

                    return createdReview;
                }

                MessageBox.Show($"Failed Operation | Could not add review");
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding review. | {ex.Message}");
            }

        }
    }
}
