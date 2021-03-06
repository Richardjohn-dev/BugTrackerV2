using AutoMapper;
using BugTracker.Application.Features.TicketStatuses.Requests.Commands;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.DTOs.TicketStatus.Validators;
using BugTracker.Application.Exceptions;

namespace BugTracker.Application.Features.TicketStatuses.Handlers.Commands
{
    public class UpdateTicketStatusCommandHandler : IRequestHandler<UpdateTicketStatusCommand, Unit>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;
        private readonly IMapper _mapper;

        public UpdateTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            _ticketStatusRepository = ticketStatusRepository;
            _mapper = mapper;
        }
            
        public async Task<Unit> Handle(UpdateTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var validator = new TicketStatusDtoValidator();
            var validationResults = await validator.ValidateAsync(request.TicketStatusDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var ticketStatus = await _ticketStatusRepository.GetAsync(request.TicketStatusDto.Id);
            _mapper.Map(request.TicketStatusDto, ticketStatus);
                
            await _ticketStatusRepository.UpdateAsync(ticketStatus);
            return Unit.Value;
        }
    }
}
