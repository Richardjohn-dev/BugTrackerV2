using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketStatuses.Requests.Commands
{
    public class DeleteTicketStatusCommand : IRequest
    {
        public int Id { get; set; }
    }
}
