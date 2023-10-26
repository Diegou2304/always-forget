using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Travelers.CreateTravelers
{
    public class CreateTravelerHandler : IRequestHandler<CreateTravelerCommand, IActionResult>
    {
        private readonly ITravelerRepository _travelerRepository;
        private readonly IAddressRepository  _addressRepository;
        
        private readonly IMapper _mapper;

        public CreateTravelerHandler(ITravelerRepository travelerRepository, 
            IMapper mapper, 
            IAddressRepository addressRepository)
        {
            _travelerRepository = travelerRepository;
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<IActionResult> Handle(CreateTravelerCommand request, CancellationToken cancellationToken)
        {

            var newTraveler = _mapper.Map<Traveler>(request);
            var traveler = await _travelerRepository.CreateTraveler(newTraveler);

            return new CreatedAtRouteResult(traveler.TravelerId, new { TravelerId = traveler.TravelerId });
            
           
            
        }
    }
}
