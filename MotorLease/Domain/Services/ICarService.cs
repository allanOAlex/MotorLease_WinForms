using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
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
        IQueryable<CarModel> GetCar(CarModel model);
        IQueryable<CarModel> GetCarModels();
        List<CarModelGridResponse> GetCarModelsForHome();
        List<CarModelGridResponse> GetCarModels2();
        int RemoveAvailability();
        List<CarMake> GetMakeComboBoxData();
        List<CarModel> GetModelComboBoxData();
        string GetCarImage(int Id);
        decimal GetUnitPrice(int carModelId);
    }
}
