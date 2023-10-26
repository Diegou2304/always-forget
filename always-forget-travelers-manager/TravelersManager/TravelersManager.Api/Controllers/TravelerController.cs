using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net.Mime;
using TravelersManager.Application.Features.Travelers.CreateTravelers;
using TravelersManager.Application.Features.Travelers.GetTravelers;

namespace TravelersManager.Api.Controllers
{
    [ApiController]
    public class TravelerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TravelerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        
        [HttpGet("travelers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetTravelers([FromQuery] GetTravelersRequest parameters)
        {
            var result = await _mediator.Send(parameters);
            return new OkObjectResult(result);

        }

        [HttpPost("travelers")]
        public async Task<IActionResult> CreateTraveler([FromBody] CreateTravelerCommand command)
        {
            
            
            return await _mediator.Send(command);
        }
    }
}
