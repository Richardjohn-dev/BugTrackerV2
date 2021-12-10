using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.Features.TicketStatuses.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketStatuses.Handlers.Commands
{
    public class DeleteTicketStatusCommandHandler : IRequestHandler<DeleteTicketStatusCommand>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;


        public DeleteTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository)
        {
            _ticketStatusRepository = ticketStatusRepository;
        }
    

        public async Task<Unit> Handle(DeleteTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var status = await _ticketStatusRepository.GetAsync(request.Id);
            await _ticketStatusRepository.DeleteAsync(status);
            return Unit.Value;
        }
    }
}

