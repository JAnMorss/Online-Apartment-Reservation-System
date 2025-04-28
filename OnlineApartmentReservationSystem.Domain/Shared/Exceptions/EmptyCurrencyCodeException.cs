using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Shared.Exceptions
{
    public class EmptyCurrencyCodeException : CustomException
    {
        public EmptyCurrencyCodeException() : base("Currency code cannot be empty.")
        {
        }
    }
}
