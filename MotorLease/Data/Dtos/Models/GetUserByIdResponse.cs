using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class GetUserByIdResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
