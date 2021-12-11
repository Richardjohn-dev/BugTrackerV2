﻿using BugTracker.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketStatus.Validators
{
    public class CreateTicketStatusDtoValidator : AbstractValidator<CreateTicketStatusDto>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;

        public CreateTicketStatusDtoValidator(ITicketStatusRepository ticketStatusRepository)
        {
            _ticketStatusRepository = ticketStatusRepository;

            Include(new ITicketStatusDtoValidator());
            RuleFor(p => p.Status)
                .MustAsync(async (Status, token) =>
                {
                    var StatusExists = await _ticketStatusRepository.Get(t=> t.Status == Status);
                    if (StatusExists == null) return true;
                    return false;
                })
                .WithMessage("{PropertyName} already exists.");
        }
    }
}
