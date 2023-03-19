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

        [ConcurrencyCheck]
        public int UserId { get; set; }

        [ConcurrencyCheck]
        public int CarModelId { get; set; }

        [ConcurrencyCheck]
        public decimal UnitPrice { get; set; }

        [ConcurrencyCheck]
        public decimal TotalPrice { get; set; }

        [ConcurrencyCheck]
        public DateTime BookingDate { get; set; }

        [ConcurrencyCheck]
        public int CreatedBy { get; set; }

        [ConcurrencyCheck]
        public DateTime DateFrom { get; set; }

        [ConcurrencyCheck]
        public DateTime DateTo { get; set; }

        [ConcurrencyCheck]
        public int UpdatedBy { get; set; }

        [DefaultValue(false)]
        public bool IsCancelled { get; set; } = false;

        [DefaultValue(false)]
        public bool IsComplete { get; set; } = false;



        [NotMapped]
        public string ModelDescription { get; set; }

        [NotMapped]
        public string ImageString { get; set; }

        [NotMapped]
        public User User { get; set; }


        [NotMapped]
        public CarModel CarModel { get; set; }


        [NotMapped]
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

        [NotMapped]
        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();


    }
}
