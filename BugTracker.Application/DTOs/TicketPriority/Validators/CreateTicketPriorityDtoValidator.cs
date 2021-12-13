using BugTracker.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketPriority.Validators
{
    public class CreateTicketPriorityDtoValidator : AbstractValidator<CreateTicketPriorityDto>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;

        public CreateTicketPriorityDtoValidator(ITicketPriorityRepository ticketPriorityRepository)
        {
            _ticketPriorityRepository = ticketPriorityRepository;

            Include(new ITicketPriorityDtoValidator());
            RuleFor(p => p.Priority)
                .MustAsync(async (Priority, token) =>
                {
                    var priorityExists = await _ticketPriorityRepository.Get(t=> t.Priority == Priority);
                    return priorityExists == null ? true : false;                  

                })
                .WithMessage("{PropertyName} already exists.");
        }
    }
}
