
using OnlineApartmentReservationSystem.Domain.Shared.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Shared
{
    public record Currency
    {
        public static readonly Currency None = new("");
        public static readonly Currency USD = new("USD");
        public static readonly Currency PESO = new("PESO");

        public string Code { get; }
        private Currency(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new EmptyCurrencyCodeException();
            }

            Code = code.ToUpper(); 
        }

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code.ToUpper())
                   ?? throw new InvalidCurrencyCodeException();
        }

        public static IReadOnlyCollection<Currency> All => new[] 
        {
            USD, 
            PESO 
        };

        public override string ToString() => Code;

        public static implicit operator string(Currency currency) => currency.Code;
        public static implicit operator Currency(string code) => FromCode(code);
    }
}
