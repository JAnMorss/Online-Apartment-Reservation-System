using OnlineApartmentReservationSystem.Domain.Users.Events;
using OnlineApartmentReservationSystem.Domain.Users.ValueObjects;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Users.Entities
{
    public sealed class User : AggregateRoot<UserId>
    {
        public UserId Id { get; private set; }
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        public Email Email { get; private set; }

        internal User(UserId id, FirstName firstName, LastName lastName, Email email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public static User Create(FirstName firstName, LastName lastName, Email email)
        {
            var user = new User(Guid.NewGuid(), firstName, lastName, email);

            user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

            return user;
        }


    }
}
