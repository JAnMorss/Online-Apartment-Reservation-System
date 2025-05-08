using OnlineApartmentReservationSystem.Domain.Apartments.Enums;
using OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects;
using OnlineApartmentReservationSystem.Domain.ValueObjects;
using OnlineApartmentReservationSystem.Shared.Abstractions.Domain;

namespace OnlineApartmentReservationSystem.Domain.Apartments.Entities
{
    public sealed class Apartment : Entity
    {
        private Apartment()
        {
        }

        public Apartment(
            Guid id, 
            ApartmentName name, 
            ApartmentDescription description, 
            ApartmentAddress address, 
            Money price, 
            Money cleaningFee, 
            List<Amenity> amenities) : base(id)
        {
            Name = name;
            Description = description;
            Address = address;
            Price = price;
            CleaningFee = cleaningFee;
            Amenities = amenities;
        }

            public ApartmentName Name { get; private set; }
            public ApartmentDescription Description { get; private set; }
            public ApartmentAddress Address { get; private set; }
            public Money Price { get; private set; }
            public Money CleaningFee { get; set; }
            public DateTime? LastBookOnUtc { get; internal set; }
            public List<Amenity> Amenities { get; private set; } = new();
    }
}
