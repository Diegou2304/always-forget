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
        public List<GetPhoneNumberDto> PhoneNumbers { get; set; } = new();
        public List<GetAddressDto> Addresses { get; set; } = new();
        public GetCategoryDto Category { get; set; }

    }

    public class GetPhoneNumberDto
    {
        public string TelefonicNumber { get; set; }
    }
    public class GetAddressDto
    {
        public string Direction { get; set; }
    }
    public class GetCategoryDto
    {
        public string CategoryName { get; set; }
    }
}
