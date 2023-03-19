using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class BookingGridResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public int CarModelId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Image Image { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
