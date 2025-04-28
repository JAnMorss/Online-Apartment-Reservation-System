namespace OnlineApartmentReservationSystem.Shared.Abstractions.Domain
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
