using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MotorLease.Data.Context;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.IRepositories;
using MotorLease.Domain.Models;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MotorLease.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DBContext context;


        public ReviewRepository(DBContext Context)
        {
            context = Context;
        }


        public int AddReview(CreateReviewRequest request)
        {
            if (request.Comments == null)
            {
                request.Comments = "No Reviews for Now, Thank you!";
            }
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"insert into Reviews(BookingId, UserId, Comments) " +
                $"values({request.BookingId}, {request.UserId}, '{request.Comments}')";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            if (result > 0)
            {
                return result;
            }

            return 0;
        }

        public Review Create(Review entity)
        {
            context.Reviews.AddAsync(entity);
            return entity;
        }

        public Review CreateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void Delete(Review entity)
        {
            throw new NotImplementedException();
        }

        public Review DeleteReview(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Review> FindAll()
        {
            return context.Reviews.AsNoTracking();
        }

        public IQueryable<Review> FindByCondition(Expression<Func<Review, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Review GetReview(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }

        public Review UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public List<ReviewGridResponse> GetUserReviews()
        {
            ReviewGridResponse response = new ReviewGridResponse();
            List<ReviewGridResponse> responseList = new List<ReviewGridResponse>();

            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select " +
                $"mk.Description as Make, " +
                $"md.Description as Model, " +
                $"r.Comments, " +
                $"(select CONCAT(u.FirstName + ' ', u.LastName)) as 'Customer Name' " +
                $"from Reviews r " +
                $"left join Bookings b on r.BookingId = b.Id " +
                $"left join Users u on r.UserId = u.Id " +
                $"left join CarModels md on b.CarModelId = md.Id " +
                $"left join CarMakes mk on md.CarMakeId = mk.Id  ";

            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = new ReviewGridResponse
                    {
                        Make = reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        Comments = reader["Comments"].ToString(),
                        Customer = reader["Customer Name"].ToString()
                        
                    };

                    responseList.Add(response);
                }
            }

            connection.Close();
            return responseList;
        }
    }
}
