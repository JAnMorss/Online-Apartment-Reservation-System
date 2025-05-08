using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineApartmentReservationSystem.Application.Abstractions.Clock;
using OnlineApartmentReservationSystem.Application.Abstractions.Email;
using OnlineApartmentReservationSystem.Infrastructure.Clock;
using OnlineApartmentReservationSystem.Infrastructure.Email;

namespace OnlineApartmentReservationSystem.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IDateTimeProvider, DateTimeProvider>();

            services.AddTransient<IEmailService, EmailService>();

            var connectionString = 
                configuration.GetConnectionString("Dabase") ??
                throw new ArgumentException(nameof(configuration));

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
            });

            return services;
        }
    }
}
