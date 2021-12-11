using BugTracker.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketType.Validators
{
    public class CreateTicketTypeDtoValidator : AbstractValidator<CreateTicketTypeDto>
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;

        public CreateTicketTypeDtoValidator(ITicketTypeRepository ticketTypeRepository)
        {
            _ticketTypeRepository = ticketTypeRepository;

            Include(new ITicketTypeDtoValidator());
            RuleFor(p => p.Type)
                .MustAsync(async (type, token) =>
                {
                    var typeExists = await _ticketTypeRepository.Get(t=> t.Type == type);
                    if (typeExists == null) return true;
                    return false;
                })
                .WithMessage("{PropertyName} already exists.");
        }
    }
}
