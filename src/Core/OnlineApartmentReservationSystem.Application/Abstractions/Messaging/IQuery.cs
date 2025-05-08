using MediatR;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
