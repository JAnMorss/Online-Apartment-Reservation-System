using Microsoft.EntityFrameworkCore;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Infrastructure
{
    public sealed class ApplicationDbContext :DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }


    }
}
