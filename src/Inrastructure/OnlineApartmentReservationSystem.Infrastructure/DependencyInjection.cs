using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineApartmentReservationSystem.Application.Abstractions.Clock;
using OnlineApartmentReservationSystem.Application.Abstractions.Data;
using OnlineApartmentReservationSystem.Application.Abstractions.Email;
using OnlineApartmentReservationSystem.Domain.Apartments.Interface;
using OnlineApartmentReservationSystem.Domain.Bookings.Repositories;
using OnlineApartmentReservationSystem.Domain.Users.Interface;
using OnlineApartmentReservationSystem.Infrastructure.Clock;
using OnlineApartmentReservationSystem.Infrastructure.Data;
using OnlineApartmentReservationSystem.Infrastructure.Email;
using OnlineApartmentReservationSystem.Infrastructure.Repositories;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

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

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

            services.AddSingleton<ISqlConnectionFactory>(_ => 
                new SqlConnectionFactory(connectionString));

            SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());

            return services;
        }
    }
}
