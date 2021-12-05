using AutoMapper;
using BugTracker.Application.Features.Tickets.Requests.Commands;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
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
        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketTypeRepository.GetAsync(request.TicketDto.Id);
            _mapper.Map(request.TicketDto, ticket);
            await _ticketTypeRepository.UpdateAsync(ticket);
            return Unit.Value;

        }
    }
}
