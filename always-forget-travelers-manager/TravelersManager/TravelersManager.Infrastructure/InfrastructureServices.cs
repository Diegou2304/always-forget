using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Infrastructure
{
    public static class InfrastructureServices
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, 
                                                                    IConfiguration configuration)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITravelerRepository, TravelerRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddDbContext<TravelersManagerDbContext>(opt => opt.UseSqlServer(
                     configuration.GetConnectionString("ConnectionString")
            ).EnableSensitiveDataLogging());

            return services;
        }
    }
}
