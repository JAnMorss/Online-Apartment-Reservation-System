using OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Bookings.Entities;
using OnlineApartmentReservationSystem.Domain.Bookings.Enums;
using OnlineApartmentReservationSystem.Domain.Bookings.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Reviews.Errors;
using OnlineApartmentReservationSystem.Domain.Reviews.Events;
using OnlineApartmentReservationSystem.Domain.Reviews.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Users.ValueObjects;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;
using OnlineApartmentReservationSystem.Shared.Abstractions.ErrorHandling;

namespace OnlineApartmentReservationSystem.Domain.Reviews.Entities
{
    public class Review : Entity
    {
        private Review()
        {
        }

        private Review(
            Guid id,
            Guid apartmentId,
            Guid bookingId,
            Guid userId,
            Rating rating,
            Comment comment,
            DateTime createdOnUtc)
            : base(id)
        {
            ApartmentId = apartmentId;
            BookingId = bookingId;
            UserId = userId;
            Rating = rating;
            Comment = comment;
            CreatedOnUtc = createdOnUtc;
        }

        public Guid ApartmentId { get; private set; }

        public Guid BookingId { get; private set; }

        public Guid UserId { get; private set; }

        public Rating Rating { get; private set; }

        public Comment Comment { get; private set; }

        public DateTime CreatedOnUtc { get; private set; }

        public static Result<Review> Create(
            Booking booking,
            Rating rating,
            Comment comment,
            DateTime createdOnUtc)
        {
            if (booking.Status != BookingStatus.Completed)
            {
                return Result.Failure<Review>(ReviewErrors.NotEligible);
            }

            var review = new Review(
                Guid.NewGuid(),
                booking.ApartmentId,
                booking.Id,
                booking.UserId,
                rating,
                comment,
                createdOnUtc);

            review.RaiseDomainEvent(new ReviewCreatedDomainEvent(review.Id));

            return review;
        }
    }
}
