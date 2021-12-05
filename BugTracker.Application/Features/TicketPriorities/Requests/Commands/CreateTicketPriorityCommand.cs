using BugTracker.Application.DTOs.TicketPriority;
using MediatR;

namespace BugTracker.Application.Features.TicketPriorities.Requests.Commands
{
    public class CreateTicketPriorityCommand : IRequest<int>
    {
        public CreateTicketPriorityDto CreateTicketPriorityDto { get; set; }
    }
}
