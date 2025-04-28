using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.Exceptions
{
    public class EmptyFirstNameException : CustomException
    {
        public EmptyFirstNameException() : base("First name cannot be empty.")
        {
        }
    }
}
