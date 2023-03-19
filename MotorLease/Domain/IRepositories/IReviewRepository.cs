using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Domain.IRepositories
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        Review CreateReview(Review review);
        int AddReview(CreateReviewRequest request);
        Review UpdateReview(Review review);
        Review DeleteReview(int Id);
        Review GetReview(int Id);
        List<ReviewGridResponse> GetUserReviews();





    }
}
