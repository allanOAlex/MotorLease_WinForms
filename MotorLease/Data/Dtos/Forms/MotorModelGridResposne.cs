using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class MotorModelGridResposne
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public string Registration { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
