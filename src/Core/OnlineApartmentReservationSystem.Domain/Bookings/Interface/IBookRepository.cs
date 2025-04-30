using OnlineApartmentReservationSystem.Domain.Apartments.Entities;
using OnlineApartmentReservationSystem.Domain.Bookings.Entities;
using OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects;

namespace OnlineApartmentReservationSystem.Domain.Bookings.Interface
{
    public interface IBookRepository
    {
        Task<Booking?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task<bool> IsOverlappingAsync(Apartment apartment, DateRange dateRange, CancellationToken cancellationToken = default);

        Apartment Add(Booking booking, CancellationToken cancellationToken = default);
    }
}
