using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.Features.TicketTypes.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Handlers.Commands
{
    public class DeleteTicketTypeCommandHandler : IRequestHandler<DeleteTicketTypeCommand>
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;
        public DeleteTicketTypeCommandHandler(ITicketTypeRepository TicketTypeRepository)
        {
            _ticketTypeRepository = TicketTypeRepository;
        }
        public async Task<Unit> Handle(DeleteTicketTypeCommand request, CancellationToken cancellationToken)
        {
            var TicketType = await _ticketTypeRepository.GetAsync(request.Id);
            await _ticketTypeRepository.DeleteAsync(TicketType);
            return Unit.Value;
        }
    }
}

