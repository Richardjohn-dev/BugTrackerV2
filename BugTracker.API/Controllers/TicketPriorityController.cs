using BugTracker.Application.DTOs.TicketPriority;
using BugTracker.Application.Features.TicketPriorities.Requests.Commands;
using BugTracker.Application.Features.Tickets.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty TicketPriority, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketPriorityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketPriorityController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        // GET: api/<TicketPriorityController>
        [HttpGet]
        public async Task<ActionResult<List<TicketPriorityDto>>> Get()
        {
            var TicketPriority = await _mediator.Send(new GetTicketPriorityListRequest());
            return Ok(TicketPriority);           
        }

        // GET api/<TicketPriorityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketPriorityDto>> Get(int id)
        {
            var TicketPriority = await _mediator.Send(new GetTicketPriorityRequest { Id = id });
            return Ok(TicketPriority);
        }

        // POST api/<TicketPriorityController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTicketPriorityDto TicketPriorityDto)
        {
            var command = new CreateTicketPriorityCommand { CreateTicketPriorityDto = TicketPriorityDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<TicketPriorityController>/
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TicketPriorityDto TicketPriorityDto)
        {
            var command = new UpdateTicketPriorityCommand { TicketPriorityDto = TicketPriorityDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<TicketPriorityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteTicketPriorityCommand { Id = id });
            return NoContent();
        }
    }
}
