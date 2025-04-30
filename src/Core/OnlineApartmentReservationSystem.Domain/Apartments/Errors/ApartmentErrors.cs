using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Errors
{
    public static class ApartmentErrors
    {
        public static Error NotFound = new("Apartment.Found", "The apartment with the specified identifier was not found");
    }
}
