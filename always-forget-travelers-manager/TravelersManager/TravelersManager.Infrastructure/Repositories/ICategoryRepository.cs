using TravelersManager.Domain;

namespace TravelersManager.Infrastructure.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category?> CreateCategory(Category category);
        Task<Category?> UpdateCategory(Category category);
        Task<Category?> GetCategoryById(int id);
        Task<bool> IsCategoryNameUniqueAsync(string categoryName);

    }
}
