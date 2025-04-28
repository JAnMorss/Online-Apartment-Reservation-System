using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.Exceptions
{
    public class EmptyUserIdException : CustomException
    {
        public EmptyUserIdException() : base("User Id cannot be empty.")
        {
        }
    }
}
