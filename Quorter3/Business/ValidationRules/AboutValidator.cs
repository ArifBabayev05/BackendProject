using System;
using DataEntities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About >
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("I know you are in hurry, but this field is required.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please Do Not Forget Upload Image.");
            RuleFor(x => x.Description).MinimumLength(15).WithMessage("Please use more than 15 charachter for Description");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Please use less than 500  charachter for Description");

        }
    }
}

