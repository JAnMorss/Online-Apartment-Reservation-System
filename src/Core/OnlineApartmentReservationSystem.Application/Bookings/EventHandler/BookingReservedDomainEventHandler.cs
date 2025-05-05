using MediatR;
using OnlineApartmentReservationSystem.Application.Abstractions.Email;
using OnlineApartmentReservationSystem.Domain.Bookings.Events;
using OnlineApartmentReservationSystem.Domain.Bookings.Interface;
using OnlineApartmentReservationSystem.Domain.Users.Interface;

namespace OnlineApartmentReservationSystem.Application.Bookings.EventHandler
{
    internal sealed class BookingReservedDomainEventHandler : INotificationHandler<BookingReservedDomainEvent>
    {
        private readonly IBookRepository _bookingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public BookingReservedDomainEventHandler(
            IBookRepository bookingRepository, 
            IUserRepository userRepository, 
            IEmailService emailService)
        {
            _bookingRepository = bookingRepository;
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public async Task Handle(BookingReservedDomainEvent notification, CancellationToken cancellationToken)
        {
            var booking = await _bookingRepository.GetByIdAsync(notification.BookingId, cancellationToken);

            if (booking is null) return;

            var user = await _userRepository.GetByIdAsync(booking.UserId, cancellationToken);

            if (user is null) return;

            await _emailService.SendAsync(
                user.Email, 
                "Booking reserved",
                "You have 10 minutes to confirm this booking");
        }
    }
}
