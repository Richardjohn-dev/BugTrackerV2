using BugTracker.Application.DTOs.TicketStatus;
using MediatR;

namespace BugTracker.Application.Features.TicketStatuses.Requests.Queries
{
    public class GetTicketStatusRequest : IRequest<TicketStatusDto>
    {
        public int Id { get; set; }
    }
}
