using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketPriority.Validators
{
    public class TicketPriorityDtoValidator : AbstractValidator<TicketPriorityDto>
    {
        public TicketPriorityDtoValidator()
        {
            Include(new ITicketPriorityDtoValidator());
        }
    }
}
