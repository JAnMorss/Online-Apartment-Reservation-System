using OnlineApartmentReservationSystem.Domain.Users.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.ValueObjects
{
    public record UserEmail
    {
        public string Value { get; }

        public UserEmail(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyEmailException();
            }

            Value = value;
        }

        public static implicit operator string(UserEmail email)
            => email.Value;

        public static implicit operator UserEmail(string email)
            => new(email);
    }
}
