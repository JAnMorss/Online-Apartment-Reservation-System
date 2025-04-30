using OnlineApartmentReservationSystem.Domain.Bookings.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects
{
    public record BookingId
    {
        public Guid Value { get; }

        public BookingId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new EmptyBookingIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(BookingId id)
            => id.Value;

        public static implicit operator BookingId(Guid id)
            => new(id);

    }
}
