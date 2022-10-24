using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User CreateUser(User entity);
        User UpdateUser(User entity);
        User ValidateUser(User entity);
        User GetByIdNumber(User request);
        Task<User> GetUserByIdNumber(User request);
    }
}
