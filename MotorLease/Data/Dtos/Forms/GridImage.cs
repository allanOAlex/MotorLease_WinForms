using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Data.Dtos.Forms
{
    public class GridImage
    {
        public int CarModelId { get; set; }
        public Image Image { get; set; }
    }
}
