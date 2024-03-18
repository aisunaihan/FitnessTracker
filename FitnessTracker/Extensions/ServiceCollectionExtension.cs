using FitnessTrackingSystem.Core.Contracts;
using FitnessTrackingSystem.Core.Services;
using FitnessTrackingSystem.Infrastructure.Data;
using FitnessTrackingSystem.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IChallengeService, ChallengeService>();
            services.AddScoped<ITrainerService, TrainerService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services,IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<FitnessTrackerDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging();
            });

            services.AddScoped<IRepository,Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services,IConfiguration config)
        {
            services
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                      options.SignIn.RequireConfirmedAccount = false;
                      options.Password.RequireDigit = true;
                      options.Password.RequiredLength = 8;
                      options.Password.RequireUppercase = true;
                      options.Password.RequireLowercase = true;
                })
                .AddEntityFrameworkStores<FitnessTrackerDbContext>();

            return services;
        }
    }
}
