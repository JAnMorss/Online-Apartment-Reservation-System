using OnlineApartmentReservationSystem.Domain.Users.Entities;
using OnlineApartmentReservationSystem.Domain.Users.Interface;

namespace OnlineApartmentReservationSystem.Infrastructure.Repositories
{
    internal sealed class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
