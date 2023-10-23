using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using TravelersManager.Application.Features.Categories;
using TravelersManager.Application.Features.Categories.CreateCategory;
using TravelersManager.Application.Features.Categories.UpdateCategory;

namespace TravelersManager.Api.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
       

        public CategoryController(IMediator mediator, IValidator<CreateCategoryCommand> createCategoryCommandValidator)
        {
            _mediator = mediator;
        }


        [HttpGet("categories")]
        public async Task<IEnumerable<GetCategoriesResult>> GetAllCategories()
        {
            var request = new GetCategoriesRequest();

            return await _mediator.Send(request);

        }

        [HttpPost("categories")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
        {
         
            await _mediator.Send(command);
            return CreatedAtRoute(command.CategoryIdentifier, new { CategoryIdentifier = command.CategoryIdentifier, CategoryId = command.CategoryIdentifier });
            
        }

        [HttpPut("categories/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryRequest request)
        {
            var command = new UpdateCategoryCommand(id, request.CategoryName);

            return await _mediator.Send(command);
            
        }

    }
}
