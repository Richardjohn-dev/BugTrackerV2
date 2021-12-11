using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketType.Validators
{
    public class TicketTypeDtoValidator : AbstractValidator<TicketTypeDto>
    {
        public TicketTypeDtoValidator()
        {
            Include(new ITicketTypeDtoValidator());
        }
    }
}
