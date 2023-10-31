using Microsoft.EntityFrameworkCore;
using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly TravelersManagerDbContext _travelersManagerDbContext;
        public AddressRepository(TravelersManagerDbContext travelersManagerDbContext)
        {
            _travelersManagerDbContext = travelersManagerDbContext;
            
        }
        public async Task<Address> CreateAddressAsync(Address address)
        {
            await _travelersManagerDbContext.Address.AddAsync(address);
            await _travelersManagerDbContext.SaveChangesAsync();

            return address;
        }

        public Task<Address> GetAddressByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Address?> GetAddressByNameAsync(string name)
        {
            return await _travelersManagerDbContext.Address.FirstOrDefaultAsync(x => x.Direction == name);
        }
    }
}
