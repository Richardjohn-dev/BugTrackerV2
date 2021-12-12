using AutoMapper;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.DTOs.TicketPriority.Validators;
using BugTracker.Application.Exceptions;

namespace BugTracker.Application.Features.TicketPriorities.Handlers.Commands
{
    public class UpdateTicketPriorityCommandHandler : IRequestHandler<UpdateTicketPriorityCommand, Unit>
    {
        private readonly ITicketPriorityRepository _ticketPriorityRepository;
        private readonly IMapper _mapper;

        public UpdateTicketPriorityCommandHandler(ITicketPriorityRepository ticketPriorityRepository, IMapper mapper)
        {
            _ticketPriorityRepository = ticketPriorityRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateTicketPriorityCommand request, CancellationToken cancellationToken)
        {
            var validator = new TicketPriorityDtoValidator();
            var validationResults = await validator.ValidateAsync(request.TicketPriorityDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var priority = await _ticketPriorityRepository.GetAsync(request.TicketPriorityDto.Id);
            priority = _mapper.Map(request.TicketPriorityDto, priority);
            await _ticketPriorityRepository.UpdateAsync(priority);
            return Unit.Value;
        }
    }
}
