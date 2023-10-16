using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelersManager.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public ICollection<Traveler> Travelers { get; } = new List<Traveler>();
        public CategoryIdentifier CategoryIdentifier { get; set;}
    }

    public enum CategoryIdentifier
    {
        Smart = 1,
        Lazy = 2,
        Forgetful = 3,
    }
}
