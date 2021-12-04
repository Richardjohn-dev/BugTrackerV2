using BugTracker.Application.DTOs.TicketType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Requests.Commands
{
    public class UpdateTicketTypeCommand : IRequest<Unit>
    {
        public TicketTypeDto TicketTypeDto { get; set; }
    }
}
