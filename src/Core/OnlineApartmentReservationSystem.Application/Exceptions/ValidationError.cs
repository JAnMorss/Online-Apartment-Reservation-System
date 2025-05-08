namespace OnlineApartmentReservationSystem.Application.Exceptions
{
    public sealed record ValidationError(string PropertyName,string ErrorMassage);
}
