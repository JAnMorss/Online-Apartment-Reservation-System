using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Events
{
    public sealed record BookingConfirmedDomainEvent(Guid bookingId) : IDomainEvent;
}
