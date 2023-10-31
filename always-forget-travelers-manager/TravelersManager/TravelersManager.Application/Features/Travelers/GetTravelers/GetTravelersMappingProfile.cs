using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TravelersManager.Application.Features.Travelers.CreateTravelers.CreateTravelerCommand;
using TravelersManager.Application.Features.Travelers.CreateTravelers;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersMappingProfile : Profile
    {
        public GetTravelersMappingProfile()
        {
            CreateMap<Traveler, GetTravelersResult>();
            CreateMap<Category, GetTravelerCategoryDto>();
            CreateMap<PhoneNumber, GetTravelerPhoneNumberDto>();
            CreateMap<Address, GetTravelerAddressDto>();

        }
    }
}
