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
    public class GetTicketStatusRequestHandler : IRequestHandler<GetTicketStatusRequest, TicketStatusDto>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;
        private readonly IMapper _mapper;

        public GetTicketStatusRequestHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            _ticketStatusRepository = ticketStatusRepository;
            _mapper = mapper;
        }
        public async Task<TicketStatusDto> Handle(GetTicketStatusRequest request, CancellationToken cancellationToken)
        {
            var ticketStatus = await _ticketStatusRepository.GetAsync(request.Id);
            return _mapper.Map<TicketStatusDto>(ticketStatus);
        }
    }
}
