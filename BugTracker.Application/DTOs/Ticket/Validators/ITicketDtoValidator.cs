using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Ticket.Validators
{
    public class ITicketDtoValidator : AbstractValidator<ITicketDto>
    {
        public ITicketDtoValidator()
        {
            RuleFor(n => n.Title)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
               .MaximumLength(100).WithMessage("{PropertyName} most not exceed 100 characters.");

            RuleFor(n => n.Description)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull()
              .MinimumLength(5).WithMessage("{PropertyName} must be at least 5 characters.")
              .MaximumLength(300).WithMessage("{PropertyName} most not exceed 300 characters.");

            //project id
            RuleFor(p => p.ProjectId).NotNull().WithMessage("{PropertyName} must be present");
            RuleFor(p => p.TicketTypeId).NotNull().WithMessage("{PropertyName} must be present");
            RuleFor(p => p.TicketPriorityId).NotNull().WithMessage("{PropertyName} must be present");
            RuleFor(p => p.TicketStatusId).NotNull().WithMessage("{PropertyName} must be present");

            //TicketTypeId
            //TicketPriorityId
            //TicketStatusId

        }
    }
}
