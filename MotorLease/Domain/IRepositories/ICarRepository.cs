using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.IRepositories
{
    public interface ICarRepository : IBaseRepository<CarModel>
    {
        IQueryable<CarModel> GetCar(CarModel model);
        List<CarModelGridResponse> GetCarModelsForHome();
        List<CarModelGridResponse> GetCarModels2();
        int RemoveAvailability();
        List<CarMake> GetMakeComboBoxData();
        List<CarModel> GetModelComboBoxData();
        string GetCarImage(int Id);
        decimal GetUnitPrice(int Id);

    }
}
