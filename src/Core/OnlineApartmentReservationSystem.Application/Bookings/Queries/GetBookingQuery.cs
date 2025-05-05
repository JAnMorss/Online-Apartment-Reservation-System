using OnlineApartmentReservationSystem.Shared.Abstractions.Application.Messaging;

namespace OnlineApartmentReservationSystem.Application.Bookings.Queries
{
    public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
}
