using Microsoft.EntityFrameworkCore.Update.Internal;
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
        public string CategoryName { get; set; }
        public ICollection<Traveler> Travelers { get; } = new List<Traveler>();
    
        private Category() { }
        
        public void Update(string categoryName)
        {
            CategoryName = categoryName;


        }
    }
        
  
}
