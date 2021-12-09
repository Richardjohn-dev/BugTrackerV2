using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Requests.Commands
{
    public class DeleteTicketTypeCommand : IRequest
    {        public int Id { get; set; }
    }
}
