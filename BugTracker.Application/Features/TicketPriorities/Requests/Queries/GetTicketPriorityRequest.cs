using BugTracker.Application.DTOs.TicketPriority;
using MediatR;

namespace BugTracker.Application.Features.Tickets.Requests.Queries
{
    public class GetTicketPriorityRequest : IRequest<TicketPriorityDto>
    {
        public int Id { get; set; }
    }
}
