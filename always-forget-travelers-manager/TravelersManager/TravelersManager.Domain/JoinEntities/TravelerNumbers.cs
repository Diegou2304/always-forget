using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelersManager.Domain.JoinEntities
{
    public class TravelerNumbers
    {
        [ForeignKey("TravelerId")]
        public int TravelerId { get; set; }
        [ForeignKey("PhoneNumberId")]
        public int PhoneNumberId { get; set; }
        public Traveler Traveler { get; set; } = null;
        public PhoneNumber PhoneNumber { get; set; } = null;

    }
}
