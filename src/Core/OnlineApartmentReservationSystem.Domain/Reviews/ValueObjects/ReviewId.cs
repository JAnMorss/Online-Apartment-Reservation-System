using OnlineApartmentReservationSystem.Domain.Apartments.Exceptions;
using OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects;

namespace OnlineApartmentReservationSystem.Domain.Reviews.ValueObjects
{
    public record ReviewId
    {
        public Guid Value { get; }

        public ReviewId(Guid value)
        {
            if (Value == Guid.Empty)
            {
                throw new EmptyApartmentIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(ReviewId id)
            => id.Value;

        public static implicit operator ReviewId(Guid id)
            => new(id);
    }
}
