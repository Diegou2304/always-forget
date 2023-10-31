using FluentValidation;
using System.Net;
using TravelersManager.Infrastructure.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .NotNull()
                .WithMessage("El nombre de la categoria no puede estar vacío");
  
        
            
        }
    }
}
