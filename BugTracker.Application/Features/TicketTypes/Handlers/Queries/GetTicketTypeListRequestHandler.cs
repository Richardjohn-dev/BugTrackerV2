using AutoMapper;
using BugTracker.Application.DTOs.TicketType;
using BugTracker.Application.Features.TicketTypes.Requests.Queries;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Handlers.Queries
{
    public class GetTicketTypeListRequestHandler : IRequestHandler<GetTicketTypeListRequest, List<TicketTypeDto>>
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public GetTicketTypeListRequestHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<TicketTypeDto>> Handle(GetTicketTypeListRequest request, CancellationToken cancellationToken)
        {
            var ticketTypes = await _ticketTypeRepository.GetAllAsync();
            return _mapper.Map<List<TicketTypeDto>>(ticketTypes);
        }
    }
}
