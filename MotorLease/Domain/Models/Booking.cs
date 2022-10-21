using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorLease.Domain.Models
{
    public class Booking
    {
        public Booking()
        {

        }

        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public CarModel CarModel { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int UpdatedBy { get; set; }

        [DefaultValue(false)]
        public bool IsCancelled { get; set; } = false;

        [DefaultValue(false)]
        public bool IsComplete { get; set; } = false;



        [NotMapped]
        public string ModelDescription { get; set; }

        [NotMapped]
        public string ImageString { get; set; }

        
        
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();


    }
}
