using Microsoft.Extensions.DependencyInjection;

namespace OnlineApartmentReservationSystem.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly);
            });

            //services.AddTransient<PricingService>();

            return services;
        }
    }
}
