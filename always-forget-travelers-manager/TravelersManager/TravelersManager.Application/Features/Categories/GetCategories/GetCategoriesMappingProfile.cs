using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Categories.GetCategories
{
    public class GetCategoriesMappingProfile : Profile
    {
        public GetCategoriesMappingProfile()
        {
            CreateMap<Category, GetCategoriesResult>();
        }
    }
}
