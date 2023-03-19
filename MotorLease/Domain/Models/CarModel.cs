using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorLease.Domain.Models
{
    public class CarModel
    {
        public CarModel()
        {

        }

        public int Id { get; set; }
        public int CarMakeId { get; set; }
        public string Description { get; set; }
        public string Registration { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsAvailable { get; set; }
        public string Image { get; set; }


        [NotMapped]
        public CarMake CarMake { get; set; }
    }
}
