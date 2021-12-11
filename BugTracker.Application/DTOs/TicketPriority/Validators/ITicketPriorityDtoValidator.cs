using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketPriority.Validators
{
    public class ITicketPriorityDtoValidator : AbstractValidator<ITicketPriorityDto>
    {
        public ITicketPriorityDtoValidator()
        {
            RuleFor(n => n.Priority)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull()
           .MinimumLength(2).WithMessage("{PropertyName} must be at least 2 characters.")
           .MaximumLength(20).WithMessage("{PropertyName} most not exceed 20 characters.");

        }
    }
}
