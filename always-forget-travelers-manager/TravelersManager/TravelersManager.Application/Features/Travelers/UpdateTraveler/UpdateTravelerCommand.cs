using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Application.Features.Travelers.GetTravelers;

namespace TravelersManager.Application.Features.Travelers.UpdateTraveler
{
    public class UpdateTravelerCommand : IRequest<IActionResult>
    {
        public int TravelerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public List<UpdateTravelerPhonenumberDto> PhoneNumbers { get; set; } = new();
        public List<UpdateTravelerAddressDto> Addresses { get; set; } = new();
        public UpdateTravelerCategoryDto Category { get; set; }

        public class UpdateTravelerPhonenumberDto
        {
            public string TelefonicNumber { get; set; }
        }
        public class UpdateTravelerAddressDto
        {
            public string Direction { get; set; }
        }
        public class UpdateTravelerCategoryDto
        {
            public int CategoryId { get; set; }
        }
    }
}
