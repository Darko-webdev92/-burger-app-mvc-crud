using BurgerApp.DAL.Repositories.Implementations;
using BurgerApp.DAL.Repositories.Interfaces;
using BurgerApp.DbModels;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Utilities
{
    public static class DependencyInjectionsExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IOrderService, OrderService>();


            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Burger>, BurgerRepository>();
            services.AddScoped<IRepository<Location>, LocationRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();


            return services;
        }

    }
}
