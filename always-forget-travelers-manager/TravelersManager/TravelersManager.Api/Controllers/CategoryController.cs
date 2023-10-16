using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Application.Features.Categories;
using TravelersManager.Domain;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Api.Controllers
{
    [ApiController]
    public class CategoryController
    {
        private readonly IMediator _mediator;
      
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("categories")]
        public async Task<IEnumerable<GetCategoriesResult>> GetAllCategories()
        {
            var request = new GetCategoriesRequest();
            return await _mediator.Send(request);

        }
    }
}
