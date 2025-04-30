using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Domain.Users.Errors
{
    public static class UserError
    {
        public static Error NotFound = new("User.Found", "The user with the specified identifier was not found");
    }
}
