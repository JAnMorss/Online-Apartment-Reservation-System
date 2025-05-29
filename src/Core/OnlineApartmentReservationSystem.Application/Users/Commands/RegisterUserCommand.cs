using OnlineApartmentReservationSystem.Application.Abstractions.Messaging;

namespace OnlineApartmentReservationSystem.Application.Users.Commands
{
    public sealed record RegisterUserCommand(
        string Email, 
        string FirstName, 
        string LastName, 
        string Password) : ICommand<Guid>;
}
