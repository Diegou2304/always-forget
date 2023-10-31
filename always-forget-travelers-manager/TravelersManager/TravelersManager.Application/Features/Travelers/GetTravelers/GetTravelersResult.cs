
using TravelersManager.Domain.JoinEntities;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersResult : Person
    {
        public int TravelerId { get; set; }
        public List<GetTravelerPhoneNumberDto> PhoneNumbers { get; } = new();
        public List<GetTravelerAddressDto> Addresses { get; set; } = new();
        public GetTravelerCategoryDto Category { get; set; }

    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Dni { get; set; }
        public CivilState CivilState { get; set; }
        public string Email { get; set; }



    }
    public class GetTravelerPhoneNumberDto
    {
        public string TelefonicNumber { get; set; }
    }
    public class GetTravelerAddressDto
    {
        public string Direction { get; set; }
    }
    public class GetTravelerCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public enum CivilState
    {

        Married = 0,
        Widow = 1,
        Single = 2

    }
}
