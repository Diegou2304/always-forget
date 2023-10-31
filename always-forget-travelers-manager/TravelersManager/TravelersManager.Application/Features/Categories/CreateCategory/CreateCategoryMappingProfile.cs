using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryMappingProfile : Profile
    {
        public CreateCategoryMappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
        }
    }
}
