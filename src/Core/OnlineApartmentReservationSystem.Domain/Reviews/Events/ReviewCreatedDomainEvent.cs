using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Reviews.Events
{
    public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
}
