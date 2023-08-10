using Microsoft.EntityFrameworkCore;
using FantasyGenerator.Core.Contracts;
using FantasyGenerator.Core.Services;
using FantasyGenerator.Infrastructure.Data;
using FantasyGenerator.Infrastructure.Data.Repositories;

namespace FantasyGenerator.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();
            //services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
