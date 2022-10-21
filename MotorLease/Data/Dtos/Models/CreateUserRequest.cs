using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class CreateUserRequest
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
