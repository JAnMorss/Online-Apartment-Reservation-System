using OnlineApartmentReservationSystem.Application.Bookings.Commands;
using OnlineApartmentReservationSystem.Domain.Apartments.Errors;
using OnlineApartmentReservationSystem.Domain.Apartments.Interface;
using OnlineApartmentReservationSystem.Domain.Bookings.Entities;
using OnlineApartmentReservationSystem.Domain.Bookings.Errors;
using OnlineApartmentReservationSystem.Domain.Bookings.Interface;
using OnlineApartmentReservationSystem.Domain.Bookings.Services;
using OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Users.Errors;
using OnlineApartmentReservationSystem.Domain.Users.Interface;
using OnlineApartmentReservationSystem.Shared.Abstractions.Commands;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Application.Bookings.CommandHandlers
{
    internal sealed class ReserveBookingCommandHandler : ICommandHandler<ReserveBookingCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly PricingService _pricingService;

        public ReserveBookingCommandHandler(
            IUserRepository userRepository, 
            IApartmentRepository apartmentRepository, 
            IBookRepository bookRepository, 
            IUnitOfWork unitOfWork, 
            PricingService pricingService)
        {
            _userRepository = userRepository;
            _apartmentRepository = apartmentRepository;
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
            _pricingService = pricingService;
        }

        public async Task<Result<Guid>> Handle(ReserveBookingCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            { 
                return Result.Failure<Guid>(UserError.NotFound); 
            }

            var apartment = await _apartmentRepository.GetByIdAsync(request.ApartmentId, cancellationToken);

            if (apartment is null)
            { 
                return Result.Failure<Guid>(ApartmentErrors.NotFound); 
            }

            var duration = DateRange.Create(request.StartDate, request.EndDate);

            if (await _bookRepository.IsOverlappingAsync(apartment, duration, cancellationToken))
            { 
                return Result.Failure<Guid>(BookingErrors.Overlap); 
            }

            var booking = Booking.Reserve(
                apartment,
                user.Id,
                duration,
                utcNow: DateTime.UtcNow,
                _pricingService);

            _bookRepository.Add(booking);   

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Success<Guid>(booking.Id);
        }
    }
}
