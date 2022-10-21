using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorLease.Domain.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User CreateUser(User entity);
        User UpdateUser(User entity);
        User ValidateUser(User entity);
    }
}
