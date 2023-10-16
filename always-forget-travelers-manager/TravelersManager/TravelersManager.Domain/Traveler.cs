
using TravelersManager.Domain.JoinEntities;

namespace TravelersManager.Domain
{
    public sealed class Traveler : Person
    {
        public int TravelerId { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; } = new();
        public List<Address> Addresses { get; set; } = new();
        public List<TravelerNumbers> TravelerNumbers { get; } = new();
        public List<TravelerAddress> TravelerAddresses { get; } = new();
        public Category Category { get; set; }


        public Traveler() { }
    }
}
