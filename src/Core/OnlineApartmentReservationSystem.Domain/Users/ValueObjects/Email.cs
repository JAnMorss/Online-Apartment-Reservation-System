using OnlineApartmentReservationSystem.Domain.Users.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.ValueObjects
{
    public record Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyEmailException();
            }

            Value = value;
        }

        public static implicit operator string(Email email)
            => email.Value;

        public static implicit operator Email(string email)
            => new(email);
    }
}
