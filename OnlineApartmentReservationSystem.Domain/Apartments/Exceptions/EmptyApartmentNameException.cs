using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Exceptions
{
    public class EmptyApartmentNameException : CustomException
    {
        public EmptyApartmentNameException() : base("Apartment name cannot be empty.")
        {
        }
    }
}
