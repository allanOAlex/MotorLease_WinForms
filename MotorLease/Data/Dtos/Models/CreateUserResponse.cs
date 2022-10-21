using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateUserResponse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int IdNumber { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
