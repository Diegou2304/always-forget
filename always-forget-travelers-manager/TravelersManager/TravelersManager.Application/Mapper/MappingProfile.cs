using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Application.Features.Categories;
using TravelersManager.Application.Features.Categories.CreateCategory;
using TravelersManager.Application.Features.Categories.GetCategories;
using TravelersManager.Application.Features.Travelers.CreateTravelers;
using TravelersManager.Application.Features.Travelers.GetTravelers;
using TravelersManager.Domain;

namespace TravelersManager.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Category, GetCategoriesResult>();
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<Traveler, GetTravelersResult>();
            CreateMap<CreateTravelerCommand, Traveler>();
            CreateMap<PhoneNumberDto,PhoneNumber>();
            CreateMap<AddressDto,Address>();
            CreateMap<CategoryDto,Category>();
            CreateMap<PhoneNumber, PhoneNumberDto>();
            CreateMap<Address,AddressDto>();
            CreateMap<Category,CategoryDto>();

        }
    }
}
