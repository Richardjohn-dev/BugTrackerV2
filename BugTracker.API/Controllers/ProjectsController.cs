using BugTracker.Application.DTOs.Project;
using BugTracker.Application.Features.Projects.Requests.Commands;
using BugTracker.Application.Features.Projects.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        // GET: api/<ProjectsController>
        [HttpGet]
        public async Task<ActionResult<List<ProjectDto>>> Get()
        {
            var projects = await _mediator.Send(new GetProjectListRequest());
            return Ok(projects);           
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> Get(int id)
        {
            var project = await _mediator.Send(new GetProjectRequest { Id = id });
            return Ok(project);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateProjectDto createProjectDto)
        {
            var command = new CreateProjectCommand { CreateProjectDto = createProjectDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<ProjectsController>/
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProjectDto projectDto)
        {
            var command = new UpdateProjectCommand { ProjectDto = projectDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProjectCommand { Id = id });
            return NoContent();
        }
    }
}
