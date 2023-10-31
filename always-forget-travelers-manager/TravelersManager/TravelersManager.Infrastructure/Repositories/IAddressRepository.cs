using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetAddressByIdAsync(int id);
        Task<Address> GetAddressByNameAsync(string name);
        Task<Address> CreateAddressAsync(Address address);
    }
}
