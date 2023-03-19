using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MotorLease.Data.Context;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.IRepositories;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MotorLease.Data.Repositories
{
    public class UserRepository : IBaseRepository<User>, IUserRepository
    {
        private readonly DBContext context;

        public UserRepository(DBContext Context)
        {
            context = Context;
        }

        public User Create(User entity)
        {
            context.Users.AddAsync(entity);
            return entity;
        }

        public User CreateUser(User entity)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString;
            string queryString = 

                $"INSERT INTO [dbo].[Users]([Username],[Password],[FirstName],[LastName],[IdNumber],[PhoneNumber],[Address],[IsAdmin]) VALUES ('{entity.Username}', '{entity.Password}','{entity.FirstName}','{entity.LastName}',{entity.IdNumber},{entity.PhoneNumber},'{entity.Address}',{0}) ";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
            }
            
            return entity;
        }

        public User ValidateUser(User entity)
        {
            var users = context.Users.AsNoTracking();
            if (users.Any())
            {
                User userToValidate = (from user in context.Users
                                       where user.Username.Equals(entity.Username) &&
                                       user.Password.Equals(entity.Password)
                                       select user).FirstOrDefault();

                return userToValidate;
            }
            
            return null;
        }

        public void Delete(User entity)
        {
            context.Remove(entity);
        }

        public IQueryable<User> FindAll()
        {
            return context.Users.AsNoTracking();
        }

        public IQueryable<User> FindByCondition(Expression<Func<User, bool>> expression)
        {
            return context.Users.Where(expression).AsNoTracking();
        }

        public void Update(User entity)
        {
            context.Update(entity);
        }

        public User UpdateUser(User entity)
        {
            context.Update(entity);
            return entity;
        }

        public User GetByIdNumber(User entity)
        {
            var user = context.Users.Where(u=> u.IdNumber == entity.IdNumber).AsNoTracking().FirstOrDefault();
            return user;
        }

        public async Task<User> GetUserByIdNumber(User request)
        {
            return await FindByCondition(user => user.Id.Equals(request.IdNumber)).FirstOrDefaultAsync();
        }
    }
}
