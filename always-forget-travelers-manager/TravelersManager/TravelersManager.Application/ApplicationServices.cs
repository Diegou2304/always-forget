using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace TravelersManager.Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
