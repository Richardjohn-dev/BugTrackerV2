using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Commands
{
    public class DeleteTicketPriorityCommandHandler : IRequestHandler<DeleteTicketPriorityCommand>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;


        public DeleteTicketPriorityCommandHandler(ITicketPriorityRepository TicketPriorityRepository)
        {
            _ticketPriorityRepository = TicketPriorityRepository;

        }
        public async Task<Unit> Handle(DeleteTicketPriorityCommand request, CancellationToken cancellationToken)
        {        
            var priority = await _ticketPriorityRepository.GetAsync(request.Id);
            await _ticketPriorityRepository.DeleteAsync(priority);
            return Unit.Value;
        }
    }
}
