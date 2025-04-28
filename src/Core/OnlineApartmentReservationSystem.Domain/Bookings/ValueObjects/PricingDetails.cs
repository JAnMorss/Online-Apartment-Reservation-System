using OnlineApartmentReservationSystem.Domain.ValueObjects;

namespace OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects
{
    public record PricingDetails(
       Money PriceForPeriod,
       Money CleaningFee,
       Money AmenitiesUpCharge,
       Money TotalPrice);
}
