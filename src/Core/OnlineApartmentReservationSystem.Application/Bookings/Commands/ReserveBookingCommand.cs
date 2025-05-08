using OnlineApartmentReservationSystem.Application.Abstractions.Messaging;

namespace OnlineApartmentReservationSystem.Application.Bookings.Commands
{
    public record ReserveBookingCommand(
        Guid ApartmentId,
        Guid UserId,
        DateOnly StartDate,
        DateOnly EndDate) : ICommand<Guid>;

}
