using OnlineApartmentReservationSystem.Application.Abstractions.Email;

namespace OnlineApartmentReservationSystem.Infrastructure.Email
{
    internal sealed class EmailService : IEmailService
    {
        public Task SendAsync(Domain.Users.ValueObjects.Email recipient, string subject, string body)
        {
            return Task.CompletedTask;
        }
    }
}
