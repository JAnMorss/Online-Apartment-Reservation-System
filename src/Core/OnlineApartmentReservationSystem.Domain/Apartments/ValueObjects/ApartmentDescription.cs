using OnlineApartmentReservationSystem.Domain.Apartments.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects
{
    public record ApartmentDescription
    {
        public string Value { get; }
        public ApartmentDescription(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyApartmentDescriptionException();
            }

            Value = value;
        }

        public static implicit operator string(ApartmentDescription description)
            => description.Value;

        public static implicit operator ApartmentDescription(string description)
            => new(description);
    }
}
