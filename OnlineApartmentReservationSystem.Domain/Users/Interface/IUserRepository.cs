using OnlineApartmentReservationSystem.Domain.Users.Entities;

namespace OnlineApartmentReservationSystem.Domain.Users.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        void Add(User user);
    }
}
