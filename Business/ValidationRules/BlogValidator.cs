using System;
using DataEntities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Feature2>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please Enter Title");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please Enter Description");
            RuleFor(x => x.MainPhoto).NotEmpty().WithMessage("Please Enter Photo");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Please Enter Title Less Than 50 Characters");
            RuleFor(x => x.Title).MinimumLength(4).WithMessage("Please Enter Title More Than 5 Characters");




        }
    }
}

