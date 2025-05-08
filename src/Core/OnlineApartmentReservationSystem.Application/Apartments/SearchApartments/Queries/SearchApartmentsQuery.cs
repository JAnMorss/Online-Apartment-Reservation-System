using OnlineApartmentReservationSystem.Application.Abstractions.Messaging;

namespace OnlineApartmentReservationSystem.Application.Apartments.SearchApartments.Queries
{
    public record SearchApartmentsQuery(
        DateOnly StartDate,
        DateOnly EndDate) : IQuery<IReadOnlyList<ApartmentResponse>>;
}
