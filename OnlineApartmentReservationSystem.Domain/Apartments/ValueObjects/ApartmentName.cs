using OnlineApartmentReservationSystem.Domain.Apartments.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects
{
    public record ApartmentName
    {
        public string Value { get; }
        public ApartmentName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyApartmentNameException();
            }

            Value = value;
        }

        public static implicit operator string(ApartmentName name) 
            => name.Value;

        public static implicit operator ApartmentName(string name)
            => new(name);

    }
}
