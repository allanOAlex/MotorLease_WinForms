using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class MyBookingsGridResponse
    {
        public Booking Booking { get; set; }
        public CarModel Model { get; set; }
        public CarMake Make { get; set; }
    }
}
