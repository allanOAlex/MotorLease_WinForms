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

        Booking UpdateBooking(Booking entity);
        public Booking CancelBooking(Booking entity);
        Booking EditBooking(Booking entity);
    }
}
