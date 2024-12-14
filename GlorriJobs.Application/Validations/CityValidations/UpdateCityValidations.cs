using FluentValidation;
using GlorriJobs.Application.dtos.CityDtos;

namespace GlorriJobs.Application.Validations.CityValidations;
public class UpdateCityValidations : AbstractValidator<UpdateCityDto>
{
    public UpdateCityValidations()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");
    }
}
