using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class BookingGridResponse
    {
        public int Id { get; set; }
        public string MakeDescription { get; set; }
        public string ModelDescription { get; set; }
        public Image Image { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
