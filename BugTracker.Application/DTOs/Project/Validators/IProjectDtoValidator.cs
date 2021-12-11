using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Project.Validators
{
    public class IProjectDtoValidator : AbstractValidator<IProjectDto>
    {
        public IProjectDtoValidator()
        {
            RuleFor(n => n.Name)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
               .MaximumLength(150).WithMessage("{PropertyName} most not exceed 150 characters.");
            
            RuleFor(n => n.Description)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull()
              .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
              .MaximumLength(150).WithMessage("{PropertyName} most not exceed 150 characters.");

            // project admin
            // company id

        }
    }
}
