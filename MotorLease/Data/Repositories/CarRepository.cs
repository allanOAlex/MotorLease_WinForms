using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MotorLease.Data.Context;
using MotorLease.Data.Dtos;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.IRepositories;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Repositories
{
    public class CarRepository : IBaseRepository<CarModel>, ICarRepository
    {
        private readonly DBContext context;

        public CarRepository(DBContext Context)
        {
            context = Context;
        }

        public CarModel Create(CarModel entity)
        {
            context.CarModels.AddAsync(entity);
            return entity;
        }

        public void Delete(CarModel entity)
        {
            context.Remove(entity);
        }
    
        public IQueryable<CarModel> FindAll()
        {
            return context.CarModels.Where(m => m.IsAvailable == true).AsNoTracking();
        }

        public IQueryable<CarModel> FindAllWithMakes()
        {
            IQueryable<CarMake> makes = context.CarMakes.AsNoTracking();
            var results = context.CarModels.Where(m => m.IsAvailable.Equals(true)).AsNoTracking();

            var resp = from result in results
                       join make in makes
                       on result.CarMake.Id equals make.Id
                       select new CarModel
                       { 

                       };
            return resp;
        }

        public IQueryable<CarModel> FindByCondition(Expression<Func<CarModel, bool>> expression)
        {
            return context.CarModels.Where(expression).AsNoTracking();
        }

        public CarModel GetAll(CarModel motorModelResponse)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MotorLease"].ConnectionString;
            string queryString = "SELECT * FROM MotorModels WHERE IsAvailable = 1 AND IsActive = 1";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                motorModelResponse.Id = Convert.ToInt32(reader["Id"]);
                motorModelResponse.CarMake.Id = Convert.ToInt32(reader["MotorMakeId"]);
                motorModelResponse.Description = reader["Description"].ToString();
                motorModelResponse.Image = reader["MotorImage"].ToString();
                motorModelResponse.Registration = reader["Registration"].ToString();
                motorModelResponse.UnitPrice = Convert.ToDecimal(reader["Price"]);
                motorModelResponse.IsAvailable = (bool)reader["IsAvailable"];
            }

            connection.Close();

            return motorModelResponse;
        }


        public void Update(CarModel entity)
        {
            context.Update(entity);
        }

        public int RemoveAvailability()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MotorLease"].ConnectionString;
            string queryString = $"UPDATE MotorModels SET IsAvailable = 0 WHERE Id = {ApplicationInfo.CarModelId}";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
