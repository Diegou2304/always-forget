using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public class TravelerRepository : ITravelerRepository
    {
        private readonly TravelersManagerDbContext _context;
        public TravelerRepository(TravelersManagerDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Traveler>> GetTravelersAsync(string? phoneNumber, string? category)
        {
            var query =  _context.Travelers.AsQueryable();

            var filteredQuery =  GetTravelerFilter(phoneNumber, category, query);



            return await filteredQuery
                .Include(a => a.Addresses)
                .Include(a => a.PhoneNumbers)
                .Include(B => B.Category)
                .AsNoTracking()
                .AsSplitQuery()
                .ToListAsync();


        }


        private IQueryable<Traveler> GetTravelerFilter(string? phoneNumber, string? category, IQueryable<Traveler> query)
        {
            var filteredQuery = query;

            if (!string.IsNullOrEmpty(category)) filteredQuery = filteredQuery
                                                                .Where(p => p.Category.CategoryName == category);
            if (!string.IsNullOrEmpty(phoneNumber)) filteredQuery = filteredQuery
                                                    .Where(x => x.PhoneNumbers.Any(pn => pn.TelefonicNumber == phoneNumber));
            return filteredQuery;
            
        }

        public async Task<Traveler?> CreateTraveler(Traveler traveler)
        {
            await _context.Travelers.AddAsync(traveler);
            int affectedRows = _context.SaveChanges();

            return affectedRows > 0 ? traveler : null;
        }

      
    }
}
