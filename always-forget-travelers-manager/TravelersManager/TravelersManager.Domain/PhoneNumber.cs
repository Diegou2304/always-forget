
using TravelersManager.Domain.JoinEntities;

namespace TravelersManager.Domain
{
    public sealed class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string TelefonicNumber { get; set;}
        public List<Traveler> Travelers { get; } = new();
        public List<TravelerNumbers> TravelerNumbers { get; } = new();
        
       
        

        public static PhoneNumber Create(string prefix, string number)
        {
            var fullNumber = prefix + number;

            return new PhoneNumber
            {
                TelefonicNumber = fullNumber,
            };
        }

        private PhoneNumber() { }

    }
}
