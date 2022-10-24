using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorLease.Domain.IRepositories
{
    public interface IBookingRepository : IBaseRepository<Booking>
    {
        List<BookingGridResponse> GetBookingsById();
        List<BookingGridResponse> GetAdminBookings();

        Booking UpdateBooking(Booking entity);
        int CancelBooking(int bookingId, int carModelId);
        Booking EditBooking(Booking entity);
    }
}
