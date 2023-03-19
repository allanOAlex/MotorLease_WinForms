using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAllBookings();
        Task<CreateBookingResponse> CreateBooking(CreateBookingRequest bookingRequest);
        IQueryable<Booking> GetBookings();
        List<BookingGridResponse> GetAdminBookings();
        List<BookingGridResponse> GetBookingsById();
        //Booking Edit(BookingGridResponse entity);
        Task<BookingGridResponse> EditBooking(BookingGridRequest entity);
        Task<BookingGridResponse> UpdateBooking(BookingGridRequest entity);
        int CancelBooking(int bookingId, int carModelId);
    }
}
