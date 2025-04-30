using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Exceptions
{
    public class EmptyBookingIdException : CustomException
    {
        public EmptyBookingIdException() : base("Booking ID cannot be empty.")
        {
        }
    }
}
