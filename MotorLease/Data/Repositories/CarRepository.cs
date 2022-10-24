using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
            return context.CarModels.Where(m => m.IsAvailable == true);
            //return context.CarModels.Where(m => m.IsAvailable == true).AsNoTracking();
        }

        public IQueryable<CarModel> GetCar(CarModel model)
        {
            return context.CarModels.Where(m => m.Id == model.Id).AsNoTracking();
        }

        public List<CarModelGridResponse> GetCarModelsForHome()
        {
            CarModelGridResponse response = new CarModelGridResponse(); 
            List<CarModelGridResponse> carModels = new List<CarModelGridResponse>();
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select " +
                $"cmd.Id, " +
                $"cmk.Description as Make, " +
                $"cmd.Description as Model, " +
                $"cmd.Registration, " +
                $"cmd.UnitPrice, " +
                $"cmd.Image " +
                $"from CarModels cmd " +
                $"left join CarMakes cmk on cmd.CarMakeId = cmk.Id " +
                $"where cmd.IsAvailable = 1 ";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = new CarModelGridResponse
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Make =reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        Registration = reader["Registration"].ToString(),
                        UnitPrice = (decimal)reader["UnitPrice"],
                        Image = AppExtension.ConvertBase64ToImage((string)reader["Image"])
                    };

                    carModels.Add(response);
                }
            }
            connection.Close();
            return carModels;
        }

        public List<CarModelGridResponse> GetCarModels2()
        {
            CarModelGridResponse response = new CarModelGridResponse();
            List<CarModelGridResponse> carModels = new List<CarModelGridResponse>();
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select " +
                $"cmd.Id, " +
                $"cmk.Description as Make, " +
                $"cmd.Description as Model, " +
                $"cmd.Registration, " +
                $"cmd.UnitPrice, " +
                $"cmd.Image " +
                $"from CarModels cmd " +
                $"left join CarMakes cmk on cmd.CarMakeId = cmk.Id ";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    response = new CarModelGridResponse
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Make = reader["Make"].ToString(),
                        Model = reader["Model"].ToString(),
                        Registration = reader["Registration"].ToString(),
                        UnitPrice = (decimal)reader["UnitPrice"],
                        Image = AppExtension.ConvertBase64ToImage((string)reader["Image"])
                    };

                    carModels.Add(response);
                }
            }
            connection.Close();
            return carModels;
        }

        public IQueryable<CarModel> FindByCondition(Expression<Func<CarModel, bool>> expression)
        {
            return context.CarModels.Where(expression).AsNoTracking();
        }

        public void Update(CarModel entity)
        {
            context.Update(entity);
        }

        public int RemoveAvailability()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"UPDATE CarModels SET IsAvailable = 0 WHERE Id = {ApplicationInfo.CarModelId}";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }

        public List<CarMake> GetMakeComboBoxData()
        {
            List<CarMake> carMakes = new List<CarMake>();
            CarMake carMake = new CarMake();    
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select cm.Id, cm.Description from CarMakes cm";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                carMake = new CarMake
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Description = reader["Description"].ToString()

                };
                carMakes.Add(carMake);  
            }

            connection.Close();

            return carMakes;
        }

        public List<CarModel> GetModelComboBoxData()
        {
            List<CarModel> carModels = new List<CarModel>();    
            CarModel model = new CarModel();
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select cm.Id, cm.CarMakeId, cm.UnitPrice, cm.Description from CarModels cm";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                model = new CarModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CarMakeId = Convert.ToInt32(reader["CarMakeId"]),
                    UnitPrice = (decimal)(reader["UnitPrice"]),
                    Description = reader["Description"].ToString()

                };
                carModels.Add(model);
            }
            connection.Close();

            return carModels;
        }

        public string GetCarImage(int Id) 
        {
            string imageString = string.Empty;
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select cm.Image from CarModels cm where Id = {Id}";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                imageString = reader["Image"].ToString();
            }
            connection.Close();

            return imageString;
        }

        public decimal GetUnitPrice(int Id) 
        {
            decimal unitPricce = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = $"select cm.UnitPrice from CarModels cm where Id = {Id}";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                unitPricce = (decimal)reader["UnitPrice"];
            }
            connection.Close();

            return unitPricce;
        }

        
    }
}
