using BugTracker.Application.DTOs.TicketStatus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketStatuses.Requests.Queries
{
    public class GetTicketStatusListRequest : IRequest<List<TicketStatusDto>>
    {
        
    }
}
