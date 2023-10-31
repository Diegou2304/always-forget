using Microsoft.EntityFrameworkCore;
using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TravelersManagerDbContext _context;
        public CategoryRepository(TravelersManagerDbContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Category.AsNoTracking().ToListAsync();
        }
        
        public async Task<Category?> CreateCategory(Category category)
        {
            await _context.Category.AddAsync(category);
            int affectedRows = _context.SaveChanges();
            
            return affectedRows > 0 ? category : null;
        }

        public async Task<Category?> UpdateCategory(Category category)
        {
            _context.Category.Update(category);
            int affectedRows = _context.SaveChanges();

            return affectedRows >= 0 ? category : null;
        }

      
        public async Task<Category?> GetCategoryById(int id)
        {
            return await _context.Category.FirstOrDefaultAsync(v => v.CategoryId == id);
        }

        public async Task<bool> IsCategoryNameUniqueAsync(string categoryName)
        {
            return !await _context.Category.AnyAsync(x => x.CategoryName == categoryName);
        }
    }
}
