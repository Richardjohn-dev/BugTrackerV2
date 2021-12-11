using AutoMapper;
using BugTracker.Application.Features.TicketTypes.Requests.Commands;
using BugTracker.Domain.Entities;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.DTOs.TicketType.Validators;
using BugTracker.Application.Exceptions;

namespace BugTracker.Application.Features.TicketTypes.Handlers.Commands
{
    public class CreateTicketTypeCommandHandler : IRequestHandler<CreateTicketTypeCommand, int>
    {

        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public CreateTicketTypeCommandHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }
    
        public async Task<int> Handle(CreateTicketTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTicketTypeDtoValidator(_ticketTypeRepository);
            var validationResults = await validator.ValidateAsync(request.CreateTicketTypeDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var ticketType = _mapper.Map<TicketType>(request.CreateTicketTypeDto);
            ticketType = await _ticketTypeRepository.AddAsync(ticketType);
            return ticketType.Id;
        }
    }
}
