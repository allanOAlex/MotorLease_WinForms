using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        public static string Address;
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

        public static Image EditBookingImage;
        public static string EditBookingMake;
        public static string EditBookingModel;
        public static DateTime EditBookingDateFrom;
        public static DateTime EditBookingDateTo;
        

        public static CreateBookingResponse CreateBookingResponse;

        public static List<BookingGridResponse> BookingGridResponses;
        public static BookingGridResponse BookingForEdit; 
        public static BookingGridResponse BookingForCancel; 
        public static BookingGridResponse BookingForReview; 
        
        public static Form CurrentForm; 
        public static Form PreviousForm; 

        public static int CancelBookingCarModelId;

        public static string Comments;
        public static decimal TotalPrice;

        public static int ReavailForBooking;


    }
}
