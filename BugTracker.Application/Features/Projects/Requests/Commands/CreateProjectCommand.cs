using BugTracker.Application.DTOs.Project;
using BugTracker.Application.DTOs.Ticket;
using MediatR;

namespace BugTracker.Application.Features.Projects.Requests.Commands
{
    public class CreateProjectCommand : IRequest<int>
    {
        public CreateProjectDto CreateProjectDto { get; set; }
    }
}
