using AutoMapper;
using TravelersManager.Domain;
using static TravelersManager.Application.Features.Travelers.CreateTravelers.CreateTravelerCommand;

namespace TravelersManager.Application.Features.Travelers.CreateTravelers
{
    public class CreateTravelerMappingProfile : Profile
    {
        public CreateTravelerMappingProfile() 
        {
            CreateMap<CreateTravelerCommand, Traveler>()
                .ForMember(dest => dest.Category, act => act.Ignore());
            CreateMap<CreateTravelerPhonenumberDto, PhoneNumber>();
            CreateMap<CreateTravelerAddressDto, Address>();


        }
    }
}
