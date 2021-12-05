using BugTracker.Application.DTOs.Ticket;
using MediatR;

namespace BugTracker.Application.Features.Tickets.Requests.Commands
{
    public class CreateTicketCommand : IRequest<int>
    {
        public CreateTicketDto CreateTicketDto { get; set; }
    }
}
