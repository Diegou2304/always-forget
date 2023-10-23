using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelersManager.Application.Features.Categories
{
    public class GetCategoriesRequest : IRequest<IEnumerable<GetCategoriesResult>> 
    {   
    }
}
