using AutoMapper;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using BugTracker.Domain.Entities;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.DTOs.TicketPriority.Validators;
using BugTracker.Application.Exceptions;

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
            var validator = new CreateTicketPriorityDtoValidator(_ticketPriorityRepository);
            var validationResults = await validator.ValidateAsync(request.CreateTicketPriorityDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var priority = _mapper.Map<TicketPriority>(request.CreateTicketPriorityDto);
            priority = await _ticketPriorityRepository.AddAsync(priority);
            return priority.Id;
        }
    }
}
