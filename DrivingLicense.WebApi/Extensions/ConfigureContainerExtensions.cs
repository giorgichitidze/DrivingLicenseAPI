using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DrivingLicense.WebApi.Factories;
using DrivingLicense.WebApi.Infastructure;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using DrivingLicense.WebApi.Services;
using DrivingLicense.WebApi.Services.Interfaces;

namespace DrivingLicense.WebApi.Extensions
{
    public static class ConfigureContainerExtensions
    {
        public static void AddDbContext(this IServiceCollection serviceCollection, string dataConnectionString = null)
        {
            if (dataConnectionString == null)
            {
                dataConnectionString = GetDataConnectionStringFromConfig();
            }
            serviceCollection.AddDbContext<DataContext>(options => options.UseSqlite(dataConnectionString));
        }

        public static void AddCorsSupport(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials().Build());
            });
        }

        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }

        private static string GetDataConnectionStringFromConfig()
        {
            return new DatabaseConfiguration().GetDataConnectionString();
        }
    }
}
