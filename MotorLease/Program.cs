using MotorLease.Client.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using MotorLease.Domain.Interfaces;
using MotorLease.Data.Interfaces;
using MotorLease.Domain.Services;
using MotorLease.Data.Services;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using MotorLease.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using MotorLease.Domain.IRepositories;
using MotorLease.Data.Repositories;

namespace MotorLease
{
    static class Program
    {

        public static IServiceProvider serviceProvider { get; set; }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ICarService, MotorService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(Program));

            services.AddDbContext<DBContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["MotorLease"].ConnectionString));

            serviceProvider = services.BuildServiceProvider();

        }

        public static T GetService<T>() where T : class
        {
            return (T)serviceProvider.GetService(typeof(T));
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var host = CreateHostBuilder().Build();
            //serviceProvider = host.Services;

            ConfigureServices();
            Application.Run(new Main());
        }

        //static IHostBuilder CreateHostBuilder()
        //{
        //    return Host.CreateDefaultBuilder()
        //    .ConfigureServices((context, services) => {
        //        services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        //        services.AddScoped<IUserRepository, UserRepository>();
        //        services.AddScoped<IBookingRepository, BookingRepository>();
        //        services.AddScoped<IUnitOfWork, UnitOfWork>();

        //        services.AddScoped<IBookingService, BookingService>();
        //        services.AddScoped<IMotorService, MotorService>();
        //        services.AddScoped<IUserService, UserService>();

        //        services.AddAutoMapper(typeof(Program));

        //    });
        //}
    }
}
