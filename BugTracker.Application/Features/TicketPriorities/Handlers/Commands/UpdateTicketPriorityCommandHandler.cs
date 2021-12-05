﻿using AutoMapper;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Commands
{
    public class UpdateTicketPriorityCommandHandler : IRequestHandler<UpdateTicketPriorityCommand, Unit>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;
        private readonly IMapper _mapper;

        public UpdateTicketPriorityCommandHandler(ITicketPriorityRepository ticketPriorityRepository, IMapper mapper)
        {
            _ticketPriorityRepository = ticketPriorityRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateTicketPriorityCommand request, CancellationToken cancellationToken)
        {
            var priority = await _ticketPriorityRepository.GetAsync(request.TicketPriorityDto.Id);
            priority = _mapper.Map(request.TicketPriorityDto, priority);
            await _ticketPriorityRepository.UpdateAsync(priority);
            return Unit.Value;
        }
    }
}