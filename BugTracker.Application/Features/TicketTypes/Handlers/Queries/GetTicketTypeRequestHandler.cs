using AutoMapper;
using BugTracker.Application.DTOs.TicketType;
using BugTracker.Application.Features.TicketTypes.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTypes.Handlers.Queries
{
    public class GetTicketTypeRequestHandler : IRequestHandler<GetTicketTypeRequest, TicketTypeDto>
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public GetTicketTypeRequestHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }
        public async Task<TicketTypeDto> Handle(GetTicketTypeRequest request, CancellationToken cancellationToken)
        {
            var ticketType = await _ticketTypeRepository.GetAsync(request.Id);
            return _mapper.Map<TicketTypeDto>(ticketType);
        }
    }
}
