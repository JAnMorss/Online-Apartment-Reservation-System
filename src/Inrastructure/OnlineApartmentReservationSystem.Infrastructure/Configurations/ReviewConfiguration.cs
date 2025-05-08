using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineApartmentReservationSystem.Domain.Apartments.Entities;
using OnlineApartmentReservationSystem.Domain.Bookings.Entities;
using OnlineApartmentReservationSystem.Domain.Users.Entities;
using OnlineApartmentReservationSystem.Domain.Reviews.ValueObjects;
using OnlineApartmentReservationSystem.Domain.Reviews.Entities;

namespace OnlineApartmentReservationSystem.Infrastructure.Configurations
{
    public sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            
            builder.ToTable("reviews");
            
            builder.HasKey(review => review.Id);
            
            builder.Property(review => review.Rating)
                   .HasConversion(rating => rating.Value, value => Rating.Create(value).Value);
            
            builder.Property(review => review.Comment)
                   .HasMaxLength(200)
                   .HasConversion(comment => comment.Value, value => new Comment(value));
            
            builder.HasOne<Apartment>()
                   .WithMany()
                   .HasForeignKey(review => review.ApartmentId);
            
            builder.HasOne<Booking>()
                   .WithMany()
                   .HasForeignKey(review => review.BookingId);
            
            builder.HasOne<User>()
                   .WithMany()
                   .HasForeignKey(review => review.UserId);
        }
    }
}
