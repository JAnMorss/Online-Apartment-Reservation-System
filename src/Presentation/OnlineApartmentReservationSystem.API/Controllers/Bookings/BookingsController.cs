using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineApartmentReservationSystem.Application.Bookings.Commands;
using OnlineApartmentReservationSystem.Application.Bookings.Queries;

namespace OnlineApartmentReservationSystem.API.Controllers.Bookings
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly ISender _sender;

        public BookingsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var query = new GetBookingQuery(id);

            var result = await _sender.Send(query, cancellationToken);

            return result.IsSuccess ? Ok(result.Value) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ReserveBooking(
            [FromBody] ReserveBookingRequest request, 
            CancellationToken cancellationToken)
        {
            if (request.StartDate > request.EndDate)
            {
                return BadRequest("Start date must not be after end date.");
            }

            var command = new ReserveBookingCommand(
                request.ApartmentId, 
                request.UserId, 
                request.StartDate, 
                request.EndDate);

            var result = await _sender.Send(command, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return CreatedAtAction(nameof(GetBooking), new { id = result.Value }, result.Value);
        }
    }
}
