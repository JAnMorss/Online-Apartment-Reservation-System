using OnlineApartmentReservationSystem.Shared.Abstractions.Exceptions;

namespace OnlineApartmentReservationSystem.Application.Abstractions.Exceptions
{
    public sealed class ValidationException : CustomException
    {
        public ValidationException(IEnumerable<ValidationError> errors)
            : base("One or more validation errors occurred.")
        {
            Errors = errors;
        }

        public IEnumerable<ValidationError> Errors { get; }
    }
}
