using BugTracker.Application.DTOs.TicketPriority;
using MediatR;

namespace BugTracker.Application.Features.TicketPriorities.Requests.Commands
{
    public class UpdateTicketPriorityCommand : IRequest<Unit>
    {
        public TicketPriorityDto TicketPriorityDto { get; set; }
    }
}
