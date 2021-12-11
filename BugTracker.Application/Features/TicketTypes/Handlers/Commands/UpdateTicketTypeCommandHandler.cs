using AutoMapper;
using BugTracker.Application.Features.TicketTypes.Requests.Commands;
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
    public class UpdateTicketTypeCommandHandler : IRequestHandler<UpdateTicketTypeCommand, Unit>
    {

        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public UpdateTicketTypeCommandHandler(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTicketTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new TicketTypeDtoValidator();
            var validationResults = await validator.ValidateAsync(request.TicketTypeDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var ticketType = await _ticketTypeRepository.GetAsync(request.TicketTypeDto.Id);
            _mapper.Map(request.TicketTypeDto, ticketType);
            await _ticketTypeRepository.UpdateAsync(ticketType);
            return Unit.Value;
        }
    }
}
