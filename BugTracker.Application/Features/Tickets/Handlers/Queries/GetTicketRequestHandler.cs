using AutoMapper;
using BugTracker.Application.DTOs.Ticket;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Handlers.Queries
{
    public class GetTicketRequestHandler : IRequestHandler<GetTicketRequest, TicketDto>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public GetTicketRequestHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<TicketDto> Handle(GetTicketRequest request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.GetAsync(request.Id);
            return _mapper.Map<TicketDto>(ticket);
        }
    }
}
