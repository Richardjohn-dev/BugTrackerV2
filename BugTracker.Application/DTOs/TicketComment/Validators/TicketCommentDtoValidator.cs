using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketComment.Validators
{
    public class TicketCommentDtoValidator : AbstractValidator<TicketCommentDto>
    {
        public TicketCommentDtoValidator()
        {
            Include(new ITicketCommentDtoValidator());
        }
    }
}
