using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Application.Features.Categories;
using TravelersManager.Application.Features.Categories.CreateCategory;
using TravelersManager.Application.Features.Categories.GetCategories;
using TravelersManager.Domain;

namespace TravelersManager.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Category, GetCategoriesResult>();
            CreateMap<CreateCategoryCommand, Category>();
        
        }
    }
}
