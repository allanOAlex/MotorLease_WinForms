using MotorLease.Data.Dtos;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.IRepositories
{
    public interface ICarRepository : IBaseRepository<CarModel>
    {
        CarModel GetAll(CarModel motorModelRequest);
        IQueryable<CarModel> FindAllWithMakes();
        int RemoveAvailability();

    }
}
