using OnlineApartmentReservationSystem.Domain.Users.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.ValueObjects
{
    public record FirstName
    {
        public string Value { get; }

        public FirstName(string value)
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyFirstNameException();
            }

            Value = value;
        }

        public static implicit operator string(FirstName firstName)
            => firstName.Value;

        public static implicit operator FirstName(string firstName)
            => new(firstName);
    }
}
