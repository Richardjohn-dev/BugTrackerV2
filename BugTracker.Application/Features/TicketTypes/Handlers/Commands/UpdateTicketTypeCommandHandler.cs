using AutoMapper;
using BugTracker.Application.Features.TicketTypes.Requests.Commands;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Handlers.Commands
{
    public class UpdateTicketTypeCommandHandler : IRequestHandler<UpdateTicketTypeCommand, Unit>
    {

        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public UpdateTicketTypeCommandHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTicketTypeCommand request, CancellationToken cancellationToken)
        {
            var ticketType = await _ticketTypeRepository.GetAsync(request.TicketTypeDto.Id);
            _mapper.Map(request.TicketTypeDto, ticketType);
            await _ticketTypeRepository.UpdateAsync(ticketType);
            return Unit.Value;
        }
    }
}
