using AutoMapper;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using BugTracker.Domain.Entities;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Commands
{
    public class CreateTicketPriorityCommandHandler : IRequestHandler<CreateTicketPriorityCommand, int>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;
        private readonly IMapper _mapper;

        public CreateTicketPriorityCommandHandler(ITicketPriorityRepository ticketPriorityRepository, IMapper mapper)
        {
            _ticketPriorityRepository = ticketPriorityRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTicketPriorityCommand request, CancellationToken cancellationToken)
        {         
            var priority = _mapper.Map<TicketPriority>(request.CreateTicketPriorityDto);
            priority = await _ticketPriorityRepository.AddAsync(priority);
            return priority.Id;
        }
    }
}
