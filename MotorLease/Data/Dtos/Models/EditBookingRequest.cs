using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class EditBookingRequest
    {

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
