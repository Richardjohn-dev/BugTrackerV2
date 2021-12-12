using BugTracker.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Ticket.Validators
{
    public class CreateTicketDtoValidator : AbstractValidator<CreateTicketDto>
    {
        private readonly ITicketRepository _ticketRepository;

        public CreateTicketDtoValidator(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;

            Include(new ITicketDtoValidator());
            // what are rules for creating a ticket?

            // depends who is calling this API really.. if its internal we will know all ID's etc are valid.

            //RuleFor(p => p.Title)
            //    .MustAsync(async (type, token) =>
            //    {
            //        var typeExists = await _TicketRepository.Get(t=> t.Title == type && t.Project == projectId);
            //        if (typeExists == null) return true;
            //        return false;
            //    })
            //    .WithMessage("{PropertyName} already exists.");
        }
    }
}
