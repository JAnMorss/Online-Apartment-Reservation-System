using OnlineApartmentReservationSystem.Application.Abstractions.Messaging;
using OnlineApartmentReservationSystem.Application.Users.Commands;
using OnlineApartmentReservationSystem.Domain.Users.Entities;
using OnlineApartmentReservationSystem.Domain.Users.Interface;
using OnlineApartmentReservationSystem.Domain.Users.ValueObjects;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Application.Users.CommandHandlers
{
    internal sealed class RegisterUserCommandHandler //: ICommandHandler<RegisterUserCommand, Guid>
    {
        /*private readonly IAuthenticationService _authenticationService;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterUserCommandHandler(IAuthenticationService authenticationService, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _authenticationService = authenticationService;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<Guid>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = User.Create(new FirstName(request.FirstName), new LastName(request.LastName), new Email(request.Email));

            var identityId = await _authenticationService.RegisterAsync(user, request.Password, cancellationToken);

            user.SetIdentityId(identityId);

            _userRepository.Add(user);

            await _unitOfWork.SaveChangesAsync();

            return user.Id;
        }*/
    }
}
