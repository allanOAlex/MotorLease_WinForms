using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MotorLease.Client.Forms;
using MotorLease.Data.Context;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.IRepositories;
using MotorLease.Domain.Models;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MotorLease.Data.Repositories
{
    public class BookingRepository : IBaseRepository<Booking>, IBookingRepository
    {
        private readonly DBContext context;

        public BookingRepository(DBContext Context)
        {
            context = Context;
        }

        public Booking Create(Booking entity)
        {
            context.Bookings.AddAsync(entity);
            return entity;
        }

        public Booking CreateBooking(Booking entity)
        {
            context.Bookings.AddAsync(entity);
            
            return entity;
        }

        public void Delete(Booking entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Booking> FindAll()
        {
            return context.Bookings.AsNoTracking();
        }

        public List<BookingGridResponse> GetBookingsById()
        {
            BookingGridResponse response = new BookingGridResponse();
            List<BookingGridResponse> responseList = new List<BookingGridResponse>();
            Image image;

            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select " +
                $"b.Id as BooKingId, " +
                $"b.UserId as CustomerId, " +
                $"(select concat(u.FirstName + ' ', u.LastName)) as 'Customer Name', " +
                $"m.Id as ModelId, " +
                $"ISNULL(cm.Description, ' ') as Make, " +
                $"ISNULL(m.Description, ' ') as Model, " +
                $"ISNULL(m.Image, ' ') as Image, " +
                $"b.DateFrom, " +
                $"b.DateTo, " +
                $"b.TotalPrice " +
                $"from Bookings b " +
                $"left join CarModels m on b.CarModelId = m.Id AND m.Description is not NULL AND m.Image is not NULL " +
                $"left join CarMakes cm on cm.Id = m.CarMakeId AND cm.Description is not NULL " +
                $"left join Users u on b.UserId = u.Id " +
                $"where b.UserId = {ApplicationInfo.UserId} and b.IsCancelled = 0 and b.IsComplete = 0  ";

            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = new BookingGridResponse
                    {
                        Id = int.Parse(reader["BooKingId"].ToString()),
                        UserId = int.Parse(reader["CustomerId"].ToString()),
                        CustomerName = reader["Customer Name"].ToString(),
                        CarModelId = int.Parse(reader["ModelId"].ToString()),
                        Make = reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        Image = AppExtension.ConvertBase64ToImage((string)reader["Image"]),
                        DateFrom = (DateTime)reader["DateFrom"],
                        DateTo = (DateTime)reader["DateTo"],
                        TotalPrice = (decimal)reader["TotalPrice"]
                    };

                    responseList.Add(response);
                }
            }

            connection.Close();
            return responseList;
        }

        public List<BookingGridResponse> GetAdminBookings()
        {
            BookingGridResponse response = new BookingGridResponse();
            List<BookingGridResponse> responseList = new List<BookingGridResponse>();
            Image image;

            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select " +
                $"b.Id as BooKingId, " +
                $"b.UserId as CustomerId, " +
                $"(select concat(u.FirstName + ' ', u.LastName)) as 'Customer Name', " +
                $"m.Id as ModelId, " +
                $"ISNULL(cm.Description, ' ') as Make, " +
                $"ISNULL(m.Description, ' ') as Model, " +
                $"ISNULL(m.Image, ' ') as Image, " +
                $"b.DateFrom, " +
                $"b.DateTo, " +
                $"b.TotalPrice " +
                $"from Bookings b " +
                $"left join CarModels m on b.CarModelId = m.Id AND m.Description is not NULL AND m.Image is not NULL " +
                $"left join CarMakes cm on cm.Id = m.CarMakeId AND cm.Description is not NULL " +
                $"left join Users u on b.UserId = u.Id " +
                $"where b.IsCancelled = 0 and b.IsComplete = 0  ";

            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = new BookingGridResponse
                    {
                        Id = int.Parse(reader["BooKingId"].ToString()),
                        UserId = int.Parse(reader["CustomerId"].ToString()),
                        CustomerName = reader["Customer Name"].ToString(),
                        CarModelId = int.Parse(reader["ModelId"].ToString()),
                        Make = reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        Image = AppExtension.ConvertBase64ToImage((string)reader["Image"]),
                        DateFrom = (DateTime)reader["DateFrom"],
                        DateTo = (DateTime)reader["DateTo"],
                        TotalPrice = (decimal)reader["TotalPrice"]
                    };

                    responseList.Add(response);
                }
            }

            connection.Close();
            return responseList;
        }

        public IQueryable<Booking> FindByCondition(Expression<Func<Booking, bool>> expression)
        {
            return context.Bookings.Where(expression).AsNoTracking();
        }

        public void Update(Booking entity)
        {
            context.Update(entity);
        }

        public Booking UpdateBooking(Booking entity)
        {
            List<string> queries = new List<string>();
            int result = 0;

            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            var connection = new SqlConnection(connectionString);

            string reavailForBooking =
                $"update CarModels set IsAvailable = 1 " +
                $"where Id = {ApplicationInfo.ReavailForBooking}";

            string unavailForBooking =
                $"update CarModels set IsAvailable = 0 " +
                $"where Id = {ApplicationInfo.CarModelId}";

            string createBooking = 
                $"update Bookings set CarModelId = {ApplicationInfo.CarModelId}, " +
                $"TotalPrice = {entity.TotalPrice}, " +
                $"DateFrom = '{entity.DateFrom}', " +
                $"DateTo = '{entity.DateTo}', " +
                $"UpdatedBy = {entity.UpdatedBy} " +
                $"where Id = {ApplicationInfo.BookingId}";

            queries.Add(reavailForBooking);
            queries.Add(unavailForBooking);
            queries.Add(createBooking);

            foreach (var query in queries)
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }

            if (result > 0)
            {
                return entity;
            }

            return null;
        }

        public int CancelBooking(int bookingId, int carModelId)
        {
            List<string> queries = new List<string>();
            int result = 0;

            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            
            string cancelBooking =
                $"update Bookings set IsCancelled = 1 " +
                $"where Id = {bookingId}";

            string availForBooking = 
                $"update CarModels set IsAvailable = 1 " +
                $"where Id = {carModelId}";

            queries.Add(cancelBooking);
            queries.Add(availForBooking);

            foreach (var query in queries)
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            
            if (result > 0)
            {
                return result;
            }
            return 0;
        }

        public Booking EditBooking(Booking entity)
        {
            context.Update(entity);
            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }



    }
}
