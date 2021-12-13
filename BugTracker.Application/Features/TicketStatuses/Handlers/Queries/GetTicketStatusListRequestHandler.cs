using AutoMapper;
using BugTracker.Application.DTOs.TicketStatus;
using BugTracker.Application.Features.TicketStatuses.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketStatuses.Handlers.Queries
{
    public class GetTicketStatusListRequestHandler : IRequestHandler<GetTicketStatusListRequest, List<TicketStatusDto>>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;
        private readonly IMapper _mapper;

        public GetTicketStatusListRequestHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            _ticketStatusRepository = ticketStatusRepository;
            _mapper = mapper;
        }

        public async Task<List<TicketStatusDto>> Handle(GetTicketStatusListRequest request, CancellationToken cancellationToken)
        {
            var ticketStatuses = await _ticketStatusRepository.GetAllAsync();
            return ticketStatuses == null ? null : _mapper.Map<List<TicketStatusDto>>(ticketStatuses);
        }
    }
}
