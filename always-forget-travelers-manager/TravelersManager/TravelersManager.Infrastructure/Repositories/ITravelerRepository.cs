using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public interface ITravelerRepository
    {
        Task<IEnumerable<Traveler>> GetTravelersAsync(string? phoneNumber, string? category);
        Task<Traveler?> CreateTraveler(Traveler traveler);
        Task<Traveler?> GetTravelerByIdAsync(int id);
        Task UpdateTravelerAsync(Traveler traveler);
    }
}
