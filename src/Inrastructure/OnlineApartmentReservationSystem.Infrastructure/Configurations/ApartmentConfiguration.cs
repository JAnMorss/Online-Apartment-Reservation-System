using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineApartmentReservationSystem.Domain.Apartments.Entities;
using OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects;
using OnlineApartmentReservationSystem.Domain.ValueObjects;

namespace OnlineApartmentReservationSystem.Infrastructure.Configurations
{
    internal sealed class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.ToTable("apartments");

            builder.HasKey(apartment => apartment.Id);

            builder.OwnsOne(apartment => apartment.Address);

            builder.Property(apartment => apartment.Name)
                   .HasMaxLength(200)
                   .HasConversion(name => name.Value, value => new ApartmentName(value));

            builder.Property(apartment => apartment.Description)
                   .HasMaxLength(2000)
                   .HasConversion(description => description.Value, value => new ApartmentDescription(value));

            builder.OwnsOne(apartment => apartment.Price, priceBuilder =>
            {
                priceBuilder.Property(money => money.Currency)
                            .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
            });

            builder.OwnsOne(apartment => apartment.CleaningFee, priceBuilder =>
            {
                priceBuilder.Property(money => money.Currency)
                            .HasConversion(currency => currency.Code, code => Currency.FromCode(code));
            });

            builder.Property<uint>("Version").IsRowVersion();
        }
    }
}
