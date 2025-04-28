using OnlineApartmentReservationSystem.Domain.Apartments.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects
{
    public record ApartmentId
    {
        public Guid Value { get; }

        public ApartmentId(Guid value)
        {
            if (Value == Guid.Empty)
            {
                throw new EmptyApartmentIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(ApartmentId id)
            => id.Value;

        public static implicit operator ApartmentId(Guid id)
            => new(id);
    }
}
