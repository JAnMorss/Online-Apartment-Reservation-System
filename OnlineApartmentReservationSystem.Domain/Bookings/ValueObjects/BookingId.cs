using OnlineApartmentReservationSystem.Domain.Users.ValueObjects;

namespace OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects
{
    public record BookingId
    {
        public Guid Value { get; }

        public BookingId(Guid value)
        {
            if (Value == Guid.Empty)
            {
                throw new ArgumentNullException("User ID cannot be empty.");
            }

            Value = value;
        }

        public static implicit operator Guid(BookingId id)
            => id.Value;

        public static implicit operator BookingId(Guid id)
            => new(id);

    }
}
