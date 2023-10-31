using FluentValidation;

namespace TravelersManager.Application.Features.Travelers.UpdateTraveler
{
    public class UpdateTravelerValidator : AbstractValidator<UpdateTravelerCommand>
    {
        public UpdateTravelerValidator() 
        {
            RuleFor(x => x.TravelerId).NotEmpty().NotNull();
        
        }
    }
}
