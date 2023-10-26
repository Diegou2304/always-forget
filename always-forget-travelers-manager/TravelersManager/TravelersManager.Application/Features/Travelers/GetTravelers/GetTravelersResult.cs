
using TravelersManager.Domain.JoinEntities;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersResult : Person
    {
        public int TravelerId { get; set; }
        public List<PhoneNumberDto> PhoneNumbers { get; } = new();
        public List<AddressDto> Addresses { get; set; } = new();
        public CategoryDto Category { get; set; }

    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string Dni { get; set; }
        public CivilState CivilState { get; set; }
        public string Email { get; set; }



    }
    public class PhoneNumberDto
    {
        public string TelefonicNumber { get; set; }
    }
    public class AddressDto
    {
        public string Direction { get; set; }
    }
    public class CategoryDto
    {
        public string CategoryName { get; set; }
    }

    public enum CivilState
    {

        Married = 0,
        Widow = 1,
        Single = 2

    }
}
