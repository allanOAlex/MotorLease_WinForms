using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Domain.Models
{
    public class CarModel
    {
        public CarModel()
        {

        }

        public int Id { get; set; }
        public CarMake CarMake { get; set; }
        public string Description { get; set; }
        public string Registration { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsAvailable { get; set; }
        public string Image { get; set; }
    }
}
