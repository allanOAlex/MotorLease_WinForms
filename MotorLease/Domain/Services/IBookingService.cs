using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
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
        List<BookingGridResponse> GetBookingsById();
        //Booking Edit(BookingGridResponse entity);
        Task<BookingGridResponse> EditBooking(BookingGridRequest entity);
    }
}
