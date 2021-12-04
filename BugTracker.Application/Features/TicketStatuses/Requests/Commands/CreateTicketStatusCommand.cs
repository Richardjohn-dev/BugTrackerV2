using BugTracker.Application.DTOs.TicketType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketStatuses.Requests.Commands
{
    public class CreateTicketStatusCommand : IRequest<int>
    {
        public CreateTicketStatusDto CreateTicketStatusDto { get; set; }
    }
}
