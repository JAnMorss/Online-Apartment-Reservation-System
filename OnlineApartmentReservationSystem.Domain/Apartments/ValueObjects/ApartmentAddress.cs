namespace OnlineApartmentReservationSystem.Domain.Apartments.ValueObjects
{
    public record ApartmentAddress(string Street, string City, string State, string ZipCode, string Country)
    {
        public static ApartmentAddress Create(string value)
        {
            var parts = value.Split(',');

            return new ApartmentAddress(
                parts[0].Trim(),
                parts[1].Trim(),
                parts[2].Trim(),
                parts[3].Trim(),
                parts[4].Trim()
            );
        }

        public override string ToString()
            => $"{Street}, {City}, {State}, {ZipCode}, {Country}";
    }
}
