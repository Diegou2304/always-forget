using MediatR;


namespace TravelersManager.Application.Features.Categories
{
    public class GetCategoriesRequest : IRequest<IEnumerable<GetCategoriesResult>> {   }
}
