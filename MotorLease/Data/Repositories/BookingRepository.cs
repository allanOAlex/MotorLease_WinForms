using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

            string base64 = "";

            var connectionString = ConfigurationManager.ConnectionStrings["MotorLease"].ConnectionString;
            string queryString = $"select " +
                $"B.UserId,ISNULL(mmd.Description, ' ') as Make, " +
                $"ISNULL(mm.Description, ' ') as Model, " +
                $"ISNULL(mm.MotorImage, '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') as Image, " +
                $"b.DateFrom, " +
                $"b.DateTo " +
                $"from Bookings b " +
                $"left join MotorModels mm on b.MotorModelId = mm.Id AND mm.Description<> NULL AND mm.MotorImage<> NULL " +
                $"left join MotorMakes mmd on mm.MotorMakeId = mmd.Id AND mmd.Description<> NULL " +
                $"where b.UserId = {ApplicationInfo.UserId}   ";

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
                        Id = int.Parse(reader["UserId"].ToString()),
                        MakeDescription = reader["Make"].ToString(),
                        ModelDescription = reader["Model"].ToString(),
                        Image = AppExtension.ConvertBase64ToImage((string)reader["Image"]),
                        DateFrom = (DateTime)reader["DateFrom"],
                        DateTo = (DateTime)reader["DateTo"]
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
            context.Update(entity);
            return entity;
        }

        public Booking CancelBooking(Booking entity)
        {
            context.Update(entity);
            return entity;
        }

        public Booking EditBooking(Booking entity)
        {
            context.Update(entity);
            return entity;
        }
    }
}
