using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace TravelersManager.Application.Features.Categories.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<IActionResult>
    {
        public UpdateCategoryCommand(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        

       
    }
    public class UpdateCategoryRequest
    {
        public string CategoryName { get; set; }
    }
  
}
