using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateBookingRequest
    {
        public int CarModelId { get; set; }
        public int UserId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
