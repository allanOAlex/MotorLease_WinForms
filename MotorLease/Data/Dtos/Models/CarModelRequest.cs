using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CarModelRequest
    {
        public int Id { get; set; }
        public int MotorTypeId { get; set; }
        public int MotorMakeId { get; set; }
        public string Description { get; set; }
        public string MotorImage { get; set; }
        public string Registration { get; set; }
        public decimal Price { get; set; }
    }
}
