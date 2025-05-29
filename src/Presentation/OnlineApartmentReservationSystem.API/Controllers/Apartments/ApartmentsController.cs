using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineApartmentReservationSystem.Application.Apartments.SearchApartments.Queries;

namespace OnlineApartmentReservationSystem.API.Controllers.Apartments
{
    [ApiController]
    [Route("api/apartments")]
    public class ApartmentsController : ControllerBase
    {
        private readonly ISender _sender;

        public ApartmentsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> SearchApartments(
            [FromQuery] DateOnly startDate,
            [FromQuery] DateOnly endDate, 
            CancellationToken cancellationToken)
        {
            if (startDate > endDate)
            {
                return BadRequest("Start date must not be later than end date.");
            }

            var query = new SearchApartmentsQuery(startDate, endDate);

            var result = await _sender.Send(query, cancellationToken);

            return Ok(result.Value);
        }
    }
}
