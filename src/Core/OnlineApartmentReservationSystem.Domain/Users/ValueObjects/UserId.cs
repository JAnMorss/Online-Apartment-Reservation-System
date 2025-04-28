using OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Users.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Users.ValueObjects
{
    public record UserId
    {
        public Guid Value { get; }

        public UserId(Guid value)
        {
            if (Value == Guid.Empty)
            {
                throw new EmptyUserIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(UserId id)
            => id.Value;

        public static implicit operator UserId(Guid id)
            => new(id);
    }
}
