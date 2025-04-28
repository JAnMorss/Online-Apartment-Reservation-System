using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Exceptions
{
    public class EmptyApartmentDescriptionException : CustomException
    {
        public EmptyApartmentDescriptionException() : base("Apartment description cannot be empty.")
        {
        }
    }
}
