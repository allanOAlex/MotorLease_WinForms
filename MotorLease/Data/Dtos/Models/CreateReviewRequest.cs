using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateReviewRequest
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }
    }
}
