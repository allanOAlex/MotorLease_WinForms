using Microsoft.EntityFrameworkCore;
using MotorLease.Domain.Models;
using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MotorLease.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DBContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LawiRides"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        //internal static int GetKey(Booking entity)
        //{
        //    return AppExtension.GetKey(DBContext, entity);
        //}

        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
