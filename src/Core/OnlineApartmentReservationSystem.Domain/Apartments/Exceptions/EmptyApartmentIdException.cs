using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Exceptions
{
    public class EmptyApartmentIdException : CustomException
    {
        public EmptyApartmentIdException() : base("Apartment Id cannot be empty.")
        {
        }
    }
}
