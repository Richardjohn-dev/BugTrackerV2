using AutoMapper;
using BugTracker.Application.DTOs.TicketPriority;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Queries
{
    public class GetTicketPriorityListRequestHandler : IRequestHandler<GetTicketPriorityListRequest, List<TicketPriorityDto>>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;
        private readonly IMapper _mapper;

        public GetTicketPriorityListRequestHandler(ITicketPriorityRepository ticketPriorityRepository, IMapper mapper)
        {
            _ticketPriorityRepository = ticketPriorityRepository;
            _mapper = mapper;
        }

        public async Task<List<TicketPriorityDto>> Handle(GetTicketPriorityListRequest request, CancellationToken cancellationToken)
        {
            var priorities = await _ticketPriorityRepository.GetAllAsync();
            return _mapper.Map<List<TicketPriorityDto>>(priorities);
        }
    }
}
