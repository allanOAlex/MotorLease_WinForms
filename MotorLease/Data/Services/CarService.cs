using AutoMapper;
using Microsoft.Extensions.Configuration;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Services
{
    public class CarService : ICarService
    {
        private readonly IConfiguration config;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CarService(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }


        public IQueryable<CarModel> GetCarModels()
        {
            var response = unitOfWork.Cars.FindAll();
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public List<CarModelGridResponse> GetCarModelsForHome()
        {
            try
            {
                var response = unitOfWork.Cars.GetCarModelsForHome();
                if (response != null)
                {
                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve records | {ex.Message}");

            }

        }

        public List<CarModelGridResponse> GetCarModels2()
        {
            try
            {
                var response = unitOfWork.Cars.GetCarModels2();
                if (response != null)
                {
                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve records | {ex.Message}");

            }

        }

        public IQueryable<CarModel> GetCar(CarModel model)
        {
            try
            {
                var response = unitOfWork.Cars.GetCar(model);
                if (response != null)
                {
                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");

            }

        }

        public int RemoveAvailability()
        {
            try
            {
                int removedItem = unitOfWork.Cars.RemoveAvailability();
                if (removedItem > 0)
                {
                    return 0;
                }
                return removedItem;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not update records: | {ex.Message}");
            }
        }

        public List<CarMake> GetMakeComboBoxData()
        {
            var result = unitOfWork.Cars.GetMakeComboBoxData();
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public List<CarModel> GetModelComboBoxData()
        {
            var result = unitOfWork.Cars.GetModelComboBoxData();
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public string GetCarImage(int carModelId)
        {
            var result = unitOfWork.Cars.GetCarImage(carModelId);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public decimal GetUnitPrice(int carModelId)
        {
            var result = unitOfWork.Cars.GetUnitPrice(carModelId);
            if (result != null)
            {
                return result;
            }

            return 0;
        }

    }
}
