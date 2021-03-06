using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketStatus.Validators
{
    public class ITicketStatusDtoValidator : AbstractValidator<ITicketStatusDto>
    {
        public ITicketStatusDtoValidator()
        {
            RuleFor(n => n.Status)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull()
           .MinimumLength(2).WithMessage("{PropertyName} must be at least 2 characters.")
           .MaximumLength(20).WithMessage("{PropertyName} most not exceed 20 characters.");


        }
    }
}
