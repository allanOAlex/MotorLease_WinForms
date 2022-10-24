using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class CarModelGridResponse
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public decimal UnitPrice { get; set; }
        public Image Image { get; set; }
    }
}
