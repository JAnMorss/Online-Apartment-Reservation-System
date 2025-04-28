using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Events
{
    public sealed class BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
}
