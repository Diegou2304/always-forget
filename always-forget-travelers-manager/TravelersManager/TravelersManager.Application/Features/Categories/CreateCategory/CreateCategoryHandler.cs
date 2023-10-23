using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Domain;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CreateCategoryHandler(ICategoryRepository category,
                                     IMapper mapper)
        {
            _categoryRepository = category;
            _mapper = mapper;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);



            await CategoryAlreadyExists(category.CategoryId);

            var result = await _categoryRepository.CreateCategory(category);
            if (result is null)
            {
                return;
            }
        }

        private async Task<bool> CategoryAlreadyExists(int categoryId)
        {
            var result = await _categoryRepository.GetCategoryById(categoryId);
            return result != null;
        }
    }
}
