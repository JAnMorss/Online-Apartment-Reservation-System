using OnlineApartmentReservationSystem.Application.Abstractions.Messaging;

namespace OnlineApartmentReservationSystem.Application.Bookings.Queries
{
    public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
}
