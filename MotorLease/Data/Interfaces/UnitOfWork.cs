using MotorLease.Data.Context;
using MotorLease.Data.Repositories;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Interfaces
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DBContext context;
        public IUserRepository Users { get; private set; }
        public IBookingRepository Bookings { get; private set; }
        public ICarRepository Motors { get; private set; }

        public UnitOfWork(DBContext Context)
        {
            context = Context;

            Users = new UserRepository(context);
            Bookings = new BookingRepository(context);
            Motors = new CarRepository(context);
        }

        public UnitOfWork()
        {

        }

        public Task CompleteAsync()
        {
            return context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
    }
}
