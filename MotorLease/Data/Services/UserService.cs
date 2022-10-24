using AutoMapper;
using MotorLease.Data.Context;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Data.Interfaces;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        private string errorMessage;

        public UserService(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            unitOfWork = UnitOfWork;
            mapper = Mapper;
        }

        public UserService()
        {
            unitOfWork = new UnitOfWork(new DBContext());
        }

        public async Task<CreateUserResponse> CreateUser(CreateUserRequest registrationRequest)
        {
            try
            {
                var request = new MapperConfiguration(cfg => cfg.CreateMap<CreateUserRequest, User>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<User, CreateUserResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                var destination = requestMap.Map<CreateUserRequest, User>(registrationRequest);
                User userToCreate = unitOfWork.Users.Create(destination);
                //User userToCreate = unitOfWork.Users.CreateUser(destination);
                var result = responseMap.Map<User, CreateUserResponse> (userToCreate);

                await unitOfWork.CompleteAsync();

                return result;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                throw new Exception($"Could not create record | {errorMessage}");
                
            }

        }

        public void DeleteUser(User user)
        {
            try
            {
                unitOfWork.Users.Delete(user);
            }
            catch (Exception ex)
            {

                throw new Exception($"Could not delete record | {ex.Message}");
            }

        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                var users = unitOfWork.Users.FindAll();
                if (users == null)
                {
                    return null;
                }
                return users.ToList();
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        public IQueryable<User> GetUsers()
        {
            try
            {
                var response = unitOfWork.Users.FindAll();
                if (response != null)
                {
                    return response;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not retreive records: | {ex.Message}");
            }
        }

        public async Task<User> GetUserById(int Id)
        {
            try
            {
                var user = unitOfWork.Users.FindByCondition(u => u.Id == Id).FirstOrDefault();
                if (user == null)
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException($"{nameof(User)} could not find record: | {ex.Message}");
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                unitOfWork.Users.Update(user);
            }
            catch (Exception ex)
            {

                throw new Exception($"Could not update record | {ex.Message}");
            }
        }

        public async Task<LoginResponse> ValidateUser(LoginRequest loginRequest)
        {
            try
            {
                var request = new MapperConfiguration(cfg => cfg.CreateMap<LoginRequest, User>());
                var response = new MapperConfiguration(cfg => cfg.CreateMap<User, LoginResponse>());

                IMapper requestMap = request.CreateMapper();
                IMapper responseMap = response.CreateMapper();

                var destination = requestMap.Map<LoginRequest, User>(loginRequest);
                User userToValidate = unitOfWork.Users.ValidateUser(destination);
                var result = responseMap.Map<User, LoginResponse>(userToValidate);

                if (result != null)
                {
                    await unitOfWork.CompleteAsync();
                    return result;
                }


                return null;

            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                throw new Exception($"Could not validate user | {errorMessage}");

            }
        }

        public async Task<GetUserByIdResponse> GetUserByIdNumber(GetUserByIdRequest request)
        {
            try
            {
                var mapRequest = new MapperConfiguration(cfg => cfg.CreateMap<GetUserByIdRequest, User>());
                var mapResponse = new MapperConfiguration(cfg => cfg.CreateMap<User, GetUserByIdResponse>());

                IMapper requestMap = mapRequest.CreateMapper();
                IMapper responseMap = mapResponse.CreateMapper();

                var destination = requestMap.Map<GetUserByIdRequest, User>(request);
                User userToGet = unitOfWork.Users.GetByIdNumber(destination);
                var result = responseMap.Map<User, GetUserByIdResponse>(userToGet);

                await unitOfWork.CompleteAsync();

                return result;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                throw new Exception($"Could not create record | {errorMessage}");

            }

        }

    }
}
