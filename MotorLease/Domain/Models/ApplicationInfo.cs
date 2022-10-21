using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotorLease.Domain.Models
{
    public static class ApplicationInfo
    {
        public static string WelcomeMessage;
        public static int UserId;
        public static string Username;
        public static string Password;
        public static string Firstname;
        public static string Lastname;
        public static string Phone;
        public static bool IsAdmin;


        public static int BookingId;
        public static DateTime BookingDate;
        public static DateTime DateFrom;
        public static DateTime DateTo;

        public static int CarMakeId;
        public static string CarMakeDescription;

        public static int CarModelId;
        public static string CarModelDescription;
        public static string CarModelRegistration;
        public static decimal CarModelUnitPrice;
        public static bool CarModelIsAvailabe;
        public static string CarModelImage;

        public static int CarId;
        public static string CarMake;
        public static string CarModel;
        public static string CarRegistration;
        public static decimal CarUnitPrice;
        public static bool CarIsAvailabe;
        public static string CarImage;

        public static CreateBookingResponse CreateBookingResponse;
         
    }
}
