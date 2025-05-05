using System.Data;

namespace OnlineApartmentReservationSystem.Application.Abstractions.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
