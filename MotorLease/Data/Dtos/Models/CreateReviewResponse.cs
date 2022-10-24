using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateReviewResponse
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }
    }
}
