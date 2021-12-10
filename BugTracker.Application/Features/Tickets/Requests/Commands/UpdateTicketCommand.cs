using BugTracker.Application.DTOs.Ticket;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Requests.Commands
{
    public class UpdateTicketCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateTicketDto UpdateTicketDto { get; set; }
        public UpdateTicketClosedDto UpdateTicketClosedDto { get; set; }
    }
}
