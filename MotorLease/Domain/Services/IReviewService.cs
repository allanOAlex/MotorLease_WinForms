using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MotorLease.Domain.Services
{
    public interface IReviewService
    {
        int AddReview(CreateReviewRequest request);
        Review Create(Review entity);
        IQueryable<Review> GetReviews();
        IQueryable<Review> FindByCondition(Expression<Func<Review, bool>> expression);
        List<ReviewGridResponse> GetUserReviews();


    }
}
