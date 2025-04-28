using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.Exceptions
{
    public class EmptyEmailException : CustomException
    {
        public EmptyEmailException() : base("Email cannot be empty.")
        {
        }
    }
}
