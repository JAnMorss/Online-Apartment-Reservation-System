using MediatR;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Application.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>, IBaseCommand
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
    {
    }

    public interface IBaseCommand
    {
    }
}
