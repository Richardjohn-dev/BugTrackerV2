using AutoMapper;
using BugTracker.Application.Features.Tickets.Requests.Commands;
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
    public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, Unit>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.GetAsync(request.Id);

            if (request.UpdateTicketDto is not null)
            {
                _mapper.Map(request.UpdateTicketDto, ticket);
                await _ticketRepository.UpdateAsync(ticket);
            }
            else if (request.UpdateTicketClosedDto != null)
            {
                await _ticketRepository.ChangeClosedStatus(ticket, request.UpdateTicketClosedDto.Closed);
            }        
            
            return Unit.Value;
        }
    }
}
