using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string description { get; set; }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }



        [NotMapped]
        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();
    }
}
