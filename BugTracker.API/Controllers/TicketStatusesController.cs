using BugTracker.Application.DTOs.TicketStatus;
using BugTracker.Application.Features.TicketStatuses.Requests.Commands;
using BugTracker.Application.Features.TicketStatuses.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty TicketStatus, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketStatusesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketStatusesController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        // GET: api/<TicketStatusController>
        [HttpGet]
        public async Task<ActionResult<List<TicketStatusDto>>> Get()
        {
            var TicketStatus = await _mediator.Send(new GetTicketStatusListRequest());
            return Ok(TicketStatus);           
        }

        // GET api/<TicketStatusController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketStatusDto>> Get(int id)
        {
            var TicketStatus = await _mediator.Send(new GetTicketStatusRequest { Id = id });
            return Ok(TicketStatus);
        }

        // POST api/<TicketStatusController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTicketStatusDto TicketStatusDto)
        {
            var command = new CreateTicketStatusCommand { CreateTicketStatusDto = TicketStatusDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<TicketStatusController>/
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TicketStatusDto TicketStatusDto)
        {
            var command = new UpdateTicketStatusCommand { TicketStatusDto = TicketStatusDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<TicketStatusController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteTicketStatusCommand { Id = id });
            return NoContent();
        }
    }
}
