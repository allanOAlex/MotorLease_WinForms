using AutoMapper;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Data.Interfaces;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MotorLease.Data.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ReviewService(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }

        public int AddReview(CreateReviewRequest request)
        {
            var response = unitOfWork.Reviews.AddReview(request);
            if (response > 0)
            {
                return response;
            }

            return 0;
        }

        public Review Create(Review entity)
        {
            var response = unitOfWork.Reviews.Create(entity);   
            return response;
        }

        public IQueryable<Review> GetReviews()
        {
            try
            {
                var response = unitOfWork.Reviews.FindAll();
                if (response != null)
                {

                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        public IQueryable<Review> FindByCondition(Expression<Func<Review, bool>> expression)
        {
            return unitOfWork.Reviews.FindByCondition(expression);  
        }

        public List<ReviewGridResponse> GetUserReviews()
        {
            try
            {
                var response = unitOfWork.Reviews.GetUserReviews();
                if (response != null)
                {
                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
