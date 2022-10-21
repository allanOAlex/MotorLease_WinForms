using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateBookingRequest
    {
        public int MotorModelId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
}
