using MotorLease.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IBookingRepository Bookings { get; }
        ICarRepository Motors { get; }

        Task CompleteAsync();
    }
}
