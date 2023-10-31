using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelersManager.Domain;
using TravelersManager.Infrastructure.Repositories;

namespace TravelersManager.Application.Features.Travelers.UpdateTraveler
{
    public  class UpdateTravelerHandler : IRequestHandler<UpdateTravelerCommand, IActionResult>
    {
        private readonly ITravelerRepository _travelerRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateTravelerHandler(ITravelerRepository travelerRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _travelerRepository = travelerRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(UpdateTravelerCommand request, CancellationToken cancellationToken)
        {
            var traveler = await _travelerRepository.GetTravelerByIdAsync(request.TravelerId);

            var newCategory = await _categoryRepository.GetCategoryById(request.Category.CategoryId);
            if (newCategory is null) return new BadRequestObjectResult(new { Message = "La categoria no existe" });
            if (traveler is null) return new BadRequestObjectResult(new {Message = "El viajero no existe"});

            traveler.Name = request.Name;
            traveler.Birthdate = request.Birthdate;
            traveler.LastName = request.LastName;
            traveler.Dni = request.Dni;
            traveler.Email = request.Email;
            traveler.PhoneNumbers = _mapper.Map<List<PhoneNumber>>(request.PhoneNumbers);
            traveler.Addresses = _mapper.Map<List<Address>>(request.Addresses);
            traveler.Category = newCategory;

            var updatedTraveler =  _travelerRepository.UpdateTravelerAsync(traveler);
            return new OkObjectResult(updatedTraveler);
        }
    }
}
