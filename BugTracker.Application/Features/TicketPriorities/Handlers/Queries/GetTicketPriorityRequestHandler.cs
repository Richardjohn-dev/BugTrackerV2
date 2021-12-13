using AutoMapper;
using BugTracker.Application.DTOs.TicketPriority;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Queries
{
    public class GetTicketPriorityRequestHandler : IRequestHandler<GetTicketPriorityRequest, TicketPriorityDto>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;
        private readonly IMapper _mapper;

        public GetTicketPriorityRequestHandler(ITicketPriorityRepository ticketPriorityRepository, IMapper mapper)
        {
            _ticketPriorityRepository = ticketPriorityRepository;
            _mapper = mapper;
        }
        public async Task<TicketPriorityDto> Handle(GetTicketPriorityRequest request, CancellationToken cancellationToken)
        {
            var priority = await _ticketPriorityRepository.GetAsync(request.Id);
            return priority == null ? null : _mapper.Map<TicketPriorityDto>(priority);
        }
    }
}
