using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TravelersManager.Application.Features.Categories
{
    public class GetCategoriesResult

    {
        public int CategoryIdentifier { get; set; }
        public string CategoryName { get; set; } = string.Empty;


    }
}
