using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discount.Calculator.Domain.interfaces.services;
using Discount.Calculator.Domain.interfaces.repository;
using Discount.Calculator.Service;
using Discount.Calculator.Repository;

namespace Discount.Calculator.API.extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies (this IServiceCollection services)
        {
            services.AddScoped<IDiscountCalculatorService, DiscountCalculatorService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommonServices, CommonServices>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
