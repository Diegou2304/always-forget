using AutoMapper;
using MediatR;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Categories.GetCategories
{
    public class GetCategoriesHandler : IRequestHandler<GetCategoriesRequest, IEnumerable<GetCategoriesResult>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCategoriesResult>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetCategories();

            return _mapper.Map<IEnumerable<GetCategoriesResult>>(result);


        }
    }
}
