using BugTracker.Application.DTOs.Ticket;
using BugTracker.Application.Features.Tickets.Requests.Commands;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<TicketsController>
        [HttpGet]
        public async Task<ActionResult<List<TicketDto>>> Get()
        {
            var Tickets = await _mediator.Send(new GetTicketListRequest());
            return Ok(Tickets);
        }

        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> Get(int id)
        {
            var result = await _mediator.Send(new GetTicketRequest { Id = id });
            return result != null ? (ActionResult) Ok(result) : NotFound();
        }

        // POST api/<TicketsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTicketDto TicketDto)
        {
            var command = new CreateTicketCommand { CreateTicketDto = TicketDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateTicketDto UpdateTicketDto)
        {
            var command = new UpdateTicketCommand { Id = id, UpdateTicketDto = UpdateTicketDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<LeaveRequestsController>/changeapproval/5
        [HttpPut("updateclosed/{id}")]
        public async Task<ActionResult> UpdateClosed(int id, [FromBody] UpdateTicketClosedDto UpdateTicketClosedDto)
        {
            var command = new UpdateTicketCommand { Id = id, UpdateTicketClosedDto = UpdateTicketClosedDto };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
