

using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersHandler : IRequestHandler<GetTravelersRequest, IActionResult>
    {
        private readonly ITravelerRepository _travelerRepository;
        private readonly IMapper _mapper;

        public GetTravelersHandler(ITravelerRepository travelerRepository, IMapper mapper)
        {
            _travelerRepository = travelerRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(GetTravelersRequest request, CancellationToken cancellationToken)
        {
            var result =  await _travelerRepository.GetTravelersAsync(request.PhoneNumber, request.Category);

            return new OkObjectResult(_mapper.Map<List<GetTravelersResult>>(result));


        }
    }
}
