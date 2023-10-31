using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Travelers.CreateTravelers
{
    public class CreateTravelerCommand : IRequest<IActionResult>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Dni { get; set; }
        public CivilState CivilState { get; set; }
        public string Email { get; set; }
        public List<CreateTravelerPhonenumberDto> PhoneNumbers { get; set; } = new();
        public List<CreateTravelerAddressDto> Addresses { get; set; } = new();
        public CreateTravelerCategoryDto Category { get; set; }
        
        public class CreateTravelerPhonenumberDto
        {
            public string TelefonicNumber { get; set; }
        }
        public class CreateTravelerAddressDto
        {
            public string Direction { get; set; }
        }
        public class CreateTravelerCategoryDto
        {
            public int CategoryId { get; set; }
        }
    }

   
}
