namespace TravelersManager.Domain.JoinEntities
{
    public class TravelerAddress
    {
        public int TravelerId { get; set; }
        public int AddressId { get; set; }
        public Traveler Traveler { get; } = null!;
        public Address Address { get; } = null!;
        public TravelerAddress() { }

    }
}