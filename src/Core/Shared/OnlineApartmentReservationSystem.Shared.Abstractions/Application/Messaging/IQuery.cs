using MediatR;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Shared.Abstractions.Queries
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
