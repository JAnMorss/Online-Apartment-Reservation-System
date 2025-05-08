using OnlineApartmentReservationSystem.Application.Abstractions.Clock;

namespace OnlineApartmentReservationSystem.Infrastructure.Clock
{
    internal sealed class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
