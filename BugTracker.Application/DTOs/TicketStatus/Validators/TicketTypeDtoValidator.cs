using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketStatus.Validators
{
    public class TicketStatusDtoValidator : AbstractValidator<TicketStatusDto>
    {
        public TicketStatusDtoValidator()
        {
            Include(new ITicketStatusDtoValidator());
        }
    }
}
