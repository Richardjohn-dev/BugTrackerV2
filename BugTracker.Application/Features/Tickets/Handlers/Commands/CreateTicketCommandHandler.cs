using AutoMapper;
using BugTracker.Application.Features.Tickets.Requests.Commands;
using BugTracker.Domain.Entities;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Handlers.Commands
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }   

        public async Task<int> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = _mapper.Map<Ticket>(request.CreateTicketDto);
            ticket = await _ticketRepository.AddAsync(ticket);
            return ticket.Id;
        }
    }
}
