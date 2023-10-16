using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain.JoinEntities;

namespace TravelersManager.Domain
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Direction { get; set; }
        public List<Traveler> Travelers { get; } = new();
        public List<TravelerAddress> TravelerAddresses { get; } = new();
    }
}
