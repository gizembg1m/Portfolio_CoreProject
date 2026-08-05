using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator: AbstractValidator<Portfolio>
    {
        public PortfolioValidator() {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Project name cannot be empty!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image area cannot be empty!");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Image2 area cannot be empty!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price area cannot be empty!")
                                 .Matches(@"^[0-9]+$").WithMessage("Price must contain only numbers!"); 
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value area cannot be empty!")                       //Value= Completion percentage of the project
                                 .GreaterThanOrEqualTo(0).WithMessage("Value must be greater than 0!")
                                 .LessThanOrEqualTo(100).WithMessage("Value cannot exceed 100!"); 
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Project name must be at least 5 characters long!");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Project name cannot exceed 100 characters!");

        }
    }
}
