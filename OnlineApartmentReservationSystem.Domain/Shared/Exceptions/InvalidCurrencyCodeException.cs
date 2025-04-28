using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Shared.Exceptions
{
    public class InvalidCurrencyCodeException : CustomException
    {
        public InvalidCurrencyCodeException() : base("The currency code is invalid.")
        {
        }
    }
}
