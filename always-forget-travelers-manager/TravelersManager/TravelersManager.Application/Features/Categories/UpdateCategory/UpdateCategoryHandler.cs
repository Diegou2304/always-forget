

using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Categories.UpdateCategory
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, IActionResult>
    {
        private readonly ICategoryRepository _categoryRepository;

        public UpdateCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public  async Task<IActionResult> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryById(request.CategoryId);
            if (category is null) return new NotFoundResult();
            
            category.Update(request.CategoryName);
            await _categoryRepository.UpdateCategory(category);
            return new OkResult();
        }
    }
}
