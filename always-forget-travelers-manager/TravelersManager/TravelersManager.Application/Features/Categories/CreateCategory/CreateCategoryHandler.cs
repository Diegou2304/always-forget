using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Domain;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand,IActionResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CreateCategoryHandler(ICategoryRepository category,
                                     IMapper mapper)
        {
            _categoryRepository = category;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        { 
            if (await _categoryRepository.IsCategoryNameUniqueAsync(request.CategoryName))
            {
                var category = _mapper.Map<Category>(request);
                var result = await _categoryRepository.CreateCategory(category);
                return new OkObjectResult(new {CategoryId = result.CategoryId});
            }
            return new BadRequestObjectResult(new { Message = "La categoria ya existe" });
        }

       
    }
}
