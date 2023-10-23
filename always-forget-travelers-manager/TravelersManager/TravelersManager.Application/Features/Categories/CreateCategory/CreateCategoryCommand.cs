using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;

namespace TravelersManager.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryCommand : IRequest
    {
        public string? CategoryName { get; set; }
        public CategoryIdentifier CategoryIdentifier { get; set; }
    }

    public enum CategoryIdentifier
    {
        Smart = 1,
        Lazy = 2,
        Forgetful = 3,
    }
}

