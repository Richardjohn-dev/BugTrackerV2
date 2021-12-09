using BugTracker.Application.DTOs.TicketType;
using BugTracker.Application.Features.TicketTypes.Requests.Commands;
using BugTracker.Application.Features.TicketTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty TicketTypes, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        // GET: api/<TicketTypesController>
        [HttpGet]
        public async Task<ActionResult<List<TicketTypeDto>>> Get()
        {
            var TicketTypes = await _mediator.Send(new GetTicketTypeListRequest());
            return Ok(TicketTypes);           
        }

        // GET api/<TicketTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketTypeDto>> Get(int id)
        {
            var TicketType = await _mediator.Send(new GetTicketTypeRequest { Id = id });
            return Ok(TicketType);
        }

        // POST api/<TicketTypesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTicketTypeDto TicketTypeDto)
        {
            var command = new CreateTicketTypeCommand { CreateTicketTypeDto = TicketTypeDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<TicketTypesController>/
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TicketTypeDto TicketTypeDto)
        {
            var command = new UpdateTicketTypeCommand { TicketTypeDto = TicketTypeDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<TicketTypesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteTicketTypeCommand { Id = id });
            return NoContent();
        }
    }
}
