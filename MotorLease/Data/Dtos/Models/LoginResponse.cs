using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Data.Dtos.Models
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}
