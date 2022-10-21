using AutoMapper;
using Microsoft.Extensions.Configuration;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Services
{
    class BookingService : IBookingService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BookingService(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            try
            {
                var bookings = unitOfWork.Bookings.FindAll();
                if (bookings == null)
                {
                    return null;
                }
                return bookings.ToList();
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        public async Task<CreateBookingResponse> CreateBooking(CreateBookingRequest bookingRequest)
        {
            try
            {
                var request = new MapperConfiguration(cfg => cfg.CreateMap<CreateBookingRequest, Booking>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<Booking, CreateBookingResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                var destination = requestMap.Map<CreateBookingRequest, Booking>(bookingRequest);
                Booking bookingToCreate = unitOfWork.Bookings.Create(destination);
                //User userToCreate = unitOfWork.Bookings.CreateBooking(destination);
                var result = responseMap.Map<Booking, CreateBookingResponse>(bookingToCreate);

                await unitOfWork.CompleteAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");

            }
        }

        public IQueryable<Booking> GetBookings()
        {
            var response = unitOfWork.Bookings.FindAll();
            if (response != null)
            {
                
                return response;
            }

            return null;
        }

        public List<BookingGridResponse> GetBookingsById()
        {
            var response = unitOfWork.Bookings.GetBookingsById();
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public Booking CancelBooking(Booking entity)
        {
            var response = unitOfWork.Bookings.CancelBooking(entity);
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public async Task<BookingGridResponse> EditBooking(BookingGridRequest entity)
        {
            try
            {
                var request = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridRequest, Booking>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingGridResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                //var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridResponse, BookingGridRequest>());
                //IMapper ResponseMapper = ResponseMap.CreateMapper();
                //var dest = ResponseMapper.Map<BookingGridResponse, BookingGridRequest>(entity);


                var destination = requestMap.Map<BookingGridRequest, Booking>(entity);
                Booking bookingToEdit = unitOfWork.Bookings.EditBooking(destination);
                var result = responseMap.Map<Booking, BookingGridResponse>(bookingToEdit);

                //await unitOfWork.CompleteAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");

            }
        }
    }
}
