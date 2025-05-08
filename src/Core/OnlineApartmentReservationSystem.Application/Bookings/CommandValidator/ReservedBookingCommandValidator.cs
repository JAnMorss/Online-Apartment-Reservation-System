using FluentValidation;
using OnlineApartmentReservationSystem.Application.Bookings.Commands;

namespace OnlineApartmentReservationSystem.Application.Bookings.CommandValidator
{
    internal class ReservedBookingCommandValidator : AbstractValidator<ReserveBookingCommand>
    {
        public ReservedBookingCommandValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.ApartmentId).NotEmpty();
            RuleFor(c => c.StartDate).LessThan(c => c.EndDate);
        }
    }
}
