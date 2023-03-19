using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotorLease.Domain.Models
{
    public class Review
    {
        public Review()
        {

        }

        [Key]
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }


        [NotMapped]
        public Booking Booking { get; set; }
        [NotMapped]
        public User User { get; set; }


        [NotMapped]
        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();

        [NotMapped]
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
