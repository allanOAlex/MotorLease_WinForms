using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotorLease.Domain.Models
{
    public class CarMake
    {
        public CarMake()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();
    }
}
