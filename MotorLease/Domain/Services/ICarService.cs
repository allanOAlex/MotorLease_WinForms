using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.Services
{
    public interface ICarService
    {
        Task<IEnumerable<CarModel>> GetAllMotors();
        Task<CarModelResponse> GetMotors(CarModelRequest motorModelRequest);
        IQueryable<CarModel> GetMotorModels();
        IQueryable<CarModel> GetMotorModelsWithMakes();
        int RemoveAvailability();
    }
}
