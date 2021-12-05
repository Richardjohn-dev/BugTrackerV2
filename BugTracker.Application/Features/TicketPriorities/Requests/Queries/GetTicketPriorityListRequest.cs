using BugTracker.Application.DTOs.TicketPriority;
using MediatR;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Tickets.Requests.Queries
{
    public class GetTicketPriorityListRequest : IRequest<List<TicketPriorityDto>>
    {
        
    }
}
