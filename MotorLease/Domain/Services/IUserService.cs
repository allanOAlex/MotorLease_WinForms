using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        IQueryable<User> GetUsers();
        Task<User> GetUserById(int Id);
        Task<CreateUserResponse> CreateUser(CreateUserRequest registrationRequest);
        void UpdateUser(User user);

        Task<LoginResponse> ValidateUser(LoginRequest loginRequest);
    }
}
