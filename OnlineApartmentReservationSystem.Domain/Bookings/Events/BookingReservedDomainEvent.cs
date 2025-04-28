using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Events
{
    public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
}
