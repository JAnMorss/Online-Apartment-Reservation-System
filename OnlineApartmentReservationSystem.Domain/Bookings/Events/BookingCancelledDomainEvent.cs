using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Events
{
    public sealed class BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
}
