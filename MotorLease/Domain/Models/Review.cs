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
        public Booking Booking { get; set; }
        public User User { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
