using OnlineApartmentReservationSystem.Domain.Users.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.ValueObjects
{
    public class LastName
    {
        public string Value { get; }

        public LastName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyLastNameException();
            }

            Value = value;
        }

        public static implicit operator string(LastName lastName)
            => lastName.Value;

        public static implicit operator LastName(string lastName)
            => new(lastName);
    }
}
