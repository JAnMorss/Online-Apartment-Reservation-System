using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Shared.Exceptions
{
    public class EqualCurrenciesException : CustomException
    {
        public EqualCurrenciesException() : base("Currencies Have To Be Equal")
        {
        }
    }
}
