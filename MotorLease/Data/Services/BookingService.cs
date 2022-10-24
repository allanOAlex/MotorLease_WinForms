using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public List<BookingGridResponse> GetAdminBookings()
        {
            var response = unitOfWork.Bookings.GetAdminBookings();
            if (response != null)
            {
                return response;
            }

            return null;
        }

        public int CancelBooking(int bookingId, int carModelId)
        {
            var response = unitOfWork.Bookings.CancelBooking(bookingId, carModelId);
            if (response > 0)
            {
                return response;
            }

            return 0;
        }
        

        public async Task<BookingGridResponse> EditBooking(BookingGridRequest entity)
        {
            try
            {
                entity.UpdatedBy = entity.Id;
                var request = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridRequest, Booking>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingGridResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                //var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridResponse, BookingGridRequest>());
                //IMapper ResponseMapper = ResponseMap.CreateMapper();
                //var dest = ResponseMapper.Map<BookingGridResponse, BookingGridRequest>(entity);


                var destination = requestMap.Map<BookingGridRequest, Booking>(entity);
                //Booking bookingToEdit = unitOfWork.Bookings.EditBooking(destination);
                Booking bookingToEdit = unitOfWork.Bookings.EditBooking(destination);
                var result = responseMap.Map<Booking, BookingGridResponse>(bookingToEdit);
                if (result != null)
                {
                    var saved = false;
                    while (!saved)
                    {
                        try
                        {
                            // Attempt to save changes to the database
                            await unitOfWork.CompleteAsync();
                            saved = true;
                        }
                        catch (DbUpdateConcurrencyException ex)
                        {
                            foreach (var entry in ex.Entries)
                            {
                                if (entry.Entity is Booking)
                                {
                                    var proposedValues = entry.CurrentValues;
                                    var databaseValues = entry.GetDatabaseValues();

                                    foreach (var property in proposedValues.Properties)
                                    {
                                        var proposedValue = proposedValues[property];
                                        //var databaseValue = databaseValues[property];

                                        // TODO: decide which value should be written to database
                                        //proposedValues[property] = <ValueTask to be added to db>
                                    }

                                    // Refresh original values to bypass next concurrency check
                                    entry.OriginalValues.SetValues(databaseValues);
                                }
                                else
                                {
                                    throw new NotSupportedException(
                                        "Don't know how to handle concurrency conflicts for "
                                        + entry.Metadata.Name);
                                }
                            }
                        }
                    }

                    return result;
                }
                
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");

            }
        }

        public async Task<BookingGridResponse> UpdateBooking(BookingGridRequest entity)
        {
            try
            {
                entity.UpdatedBy = ApplicationInfo.UserId;
                var request = new MapperConfiguration(cfg => cfg.CreateMap<BookingGridRequest, Booking>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingGridResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                var destination = requestMap.Map<BookingGridRequest, Booking>(entity);
                //Booking bookingToEdit = unitOfWork.Bookings.EditBooking(destination);
                Booking bookingToEdit = unitOfWork.Bookings.UpdateBooking(destination);
                var result = responseMap.Map<Booking, BookingGridResponse>(bookingToEdit);
                if (result != null)
                {
                    await unitOfWork.CompleteAsync();

                    return result;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not create record | {ex.Message}");

            }
        }

    }
}
