using AutoMapper;
using BugTracker.Application.DTOs.Ticket;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Handlers.Queries
{
    public class GetTicketListRequestHandler : IRequestHandler<GetTicketListRequest, List<TicketDto>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public GetTicketListRequestHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
    
        public async Task<List<TicketDto>> Handle(GetTicketListRequest request, CancellationToken cancellationToken)
        {
            var tickets = await _ticketRepository.GetAllAsync();
            return tickets == null ? null : _mapper.Map<List<TicketDto>>(tickets);            
        }
    }
}
