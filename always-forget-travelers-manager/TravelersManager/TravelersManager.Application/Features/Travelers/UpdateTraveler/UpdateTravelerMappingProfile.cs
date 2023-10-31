using AutoMapper;
using TravelersManager.Domain;
using static TravelersManager.Application.Features.Travelers.UpdateTraveler.UpdateTravelerCommand;

namespace TravelersManager.Application.Features.Travelers.UpdateTraveler
{
    public class UpdateTravelerMappingProfile : Profile
    {
        public UpdateTravelerMappingProfile()
        {
            CreateMap<UpdateTravelerCommand, Traveler>();
            CreateMap<UpdateTravelerPhonenumberDto, PhoneNumber>();
            CreateMap<UpdateTravelerAddressDto, Address>();
            CreateMap<UpdateTravelerCategoryDto, Category>();
        }

    }
}
