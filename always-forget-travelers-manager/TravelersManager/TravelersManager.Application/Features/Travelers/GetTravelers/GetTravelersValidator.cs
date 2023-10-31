

using FluentValidation;
using System.Text.RegularExpressions;

namespace TravelersManager.Application.Features.Travelers.GetTravelers
{
    public class GetTravelersValidator : AbstractValidator<GetTravelersRequest>
    {

        public GetTravelersValidator()
        {

            RuleFor(x => x.PhoneNumber).Custom((num, context) =>
            {
                var pattern = "^[0-9]+$";
                if (!Regex.IsMatch(num, pattern)) context.AddFailure("El numero no debe contener letras");

            }).When(x => !string.IsNullOrEmpty(x.PhoneNumber));

           
        }

      
    }
}
