using AutoMapper;
using Microsoft.Extensions.Configuration;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Services
{
    public class MotorService : ICarService
    {
        private readonly IConfiguration config;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public MotorService(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }


        public IQueryable<CarModel> GetMotorModels()
        {
            var response = unitOfWork.Motors.FindAll();
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public IQueryable<CarModel> GetMotorModelsWithMakes()
        {
            var response = unitOfWork.Motors.FindAllWithMakes(); 
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public async Task<IEnumerable<CarModel>> GetAllMotors()
        {
            try
            {
                var motors = unitOfWork.Motors.FindAll();
                if (motors == null)
                {
                    return null;
                }
                return motors.ToList();
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        public async Task<CarModelResponse> GetMotors(CarModelRequest motorModelRequest)
        {
            try
            {
                var request = new MapperConfiguration(cfg => cfg.CreateMap<CarModelRequest, CarModel>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<CarModel, CarModelResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                var destination = requestMap.Map<CarModelRequest, CarModel>(motorModelRequest);
                CarModel motorModels = unitOfWork.Motors.GetAll(destination);
                var result = responseMap.Map<CarModel, CarModelResponse>(motorModels);

                await unitOfWork.CompleteAsync();

                return result;
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
                int removedItem = unitOfWork.Motors.RemoveAvailability();
                if (removedItem !> 0)
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

    }
}
