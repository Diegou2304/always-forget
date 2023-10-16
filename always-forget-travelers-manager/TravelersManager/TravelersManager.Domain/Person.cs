
using System.Runtime;

namespace TravelersManager.Domain
{
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

    public enum CivilState
    {

        Married = 0,
        Widow = 1,
        Single = 2

    }

}
