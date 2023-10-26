using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersRequest : IRequest<IActionResult>
    {
       
        public string? PhoneNumber { get; set; }
        public string? Category { get; set; }
    }
}
