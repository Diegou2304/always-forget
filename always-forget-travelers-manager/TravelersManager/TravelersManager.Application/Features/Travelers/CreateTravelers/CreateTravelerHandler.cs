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
        private readonly ICategoryRepository _categoryRepository;
        
        private readonly IMapper _mapper;

        public CreateTravelerHandler(ITravelerRepository travelerRepository,
            IMapper mapper,
            IAddressRepository addressRepository,
            ICategoryRepository categoryRepository)
        {
            _travelerRepository = travelerRepository;
            _mapper = mapper;
            _addressRepository = addressRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Handle(CreateTravelerCommand request, CancellationToken cancellationToken)
        {

           
            var category = await _categoryRepository.GetCategoryById(request.Category.CategoryId);

            if (category is null) return new BadRequestObjectResult(new { Message = "La categoria no es válida, por favor introduzca una existente"});

            var newTraveler = _mapper.Map<Traveler>(request);
            newTraveler.Category = category;

            //Tengo que crear los telefonos, y direcciones, pero no las categorias.
            var traveler = await _travelerRepository.CreateTraveler(newTraveler);

            return new CreatedAtRouteResult(traveler.TravelerId, new { TravelerId = traveler.TravelerId });
            
           
            
        }
    }
}
