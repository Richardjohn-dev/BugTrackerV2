using AutoMapper;
using BugTracker.Application.Features.TicketStatuses.Requests.Commands;
using BugTracker.Domain.Entities;
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
    public class CreateTicketStatusCommandHandler : IRequestHandler<CreateTicketStatusCommand, int>
    {
        private readonly ITicketStatusRepository _ticketStatusRepository;
        private readonly IMapper _mapper;

        public CreateTicketStatusCommandHandler(ITicketStatusRepository ticketStatusRepository, IMapper mapper)
        {
            _ticketStatusRepository = ticketStatusRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTicketStatusDtoValidator(_ticketStatusRepository);
            var validationResults = await validator.ValidateAsync(request.CreateTicketStatusDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var ticketStatus = _mapper.Map<TicketStatus>(request.CreateTicketStatusDto);
            ticketStatus = await _ticketStatusRepository.AddAsync(ticketStatus);
            return ticketStatus.Id;
        }

    }
}
