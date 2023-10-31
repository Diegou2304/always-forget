using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryCommand : IRequest<IActionResult>
    {
        public string? CategoryName { get; set; }
    
    }

}

