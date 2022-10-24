using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class BookingGridRequest
    {
        public int Id { get; set; }
        public int CarModelId { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int UpdatedBy { get; set; }
    }
}
