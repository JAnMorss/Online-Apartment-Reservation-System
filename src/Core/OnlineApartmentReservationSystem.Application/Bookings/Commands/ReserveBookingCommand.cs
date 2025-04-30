using OnlineApartmentReservationSystem.Shared.Abstractions.Application.Messaging;

namespace OnlineApartmentReservationSystem.Application.Bookings.Commands
{
    public record ReserveBookingCommand(
        Guid ApartmentId,
        Guid UserId,
        DateOnly StartDate,
        DateOnly EndDate) : ICommand<Guid>;

}
