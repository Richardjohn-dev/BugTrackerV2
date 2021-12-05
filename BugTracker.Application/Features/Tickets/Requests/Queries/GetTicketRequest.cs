using BugTracker.Application.DTOs.Ticket;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Requests.Queries
{
    public class GetTicketRequest : IRequest<TicketDto>
    {
        public int Id { get; set; }
    }
}
