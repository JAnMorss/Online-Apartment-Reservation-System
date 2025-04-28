using OnlineApartmentReservationSystem.Domain.Apartments.Entities;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Interface
{
    public interface IApartmentRepository
    {
        Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
