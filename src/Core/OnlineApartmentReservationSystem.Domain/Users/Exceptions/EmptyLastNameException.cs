using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.Exceptions
{
    public class EmptyLastNameException : CustomException
    {
        public EmptyLastNameException() : base("Last name cannot be empty.")
        {
        }
    }
}
