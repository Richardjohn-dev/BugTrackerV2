using AutoMapper;
using BugTracker.Application.Features.Tickets.Requests.Commands;
using BugTracker.Domain.Entities;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.Contracts.Infrastructure;
using BugTracker.Application.Models;

namespace BugTracker.Application.Features.Tickets.Handlers.Commands
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IEmailSender emailSender, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _emailSender = emailSender;
            _mapper = mapper;
        }   

        public async Task<int> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = _mapper.Map<Ticket>(request.CreateTicketDto);
            ticket.AssigneeUser = null;
            ticket.ReporterUser = null;
            // add validation for this to ensure assigned users are correct
            ticket = await _ticketRepository.AddAsync(ticket);

            // send an email sample
            var email = new Email
            {                
                To = "assignee@org.com",
                Body = TicketCreatedEmailBody(ticket),
                Subject = "New Ticket Created"
            };
            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception)
            {
                //// Log or handle error, but don't throw...
            }

            return ticket.Id;
        }

        private static string TicketCreatedEmailBody(Ticket ticket)
        {
            return $"Ticket Title: {ticket.Title} Desc: {ticket.Description} ";
        }
    }
}
