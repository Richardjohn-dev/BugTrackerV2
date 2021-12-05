using BugTracker.Application.DTOs.Project;
using MediatR;

namespace BugTracker.Application.Features.Projects.Requests.Commands
{
    public class UpdateProjectCommand : IRequest<Unit>
    {
        public UpdateProjectDto UpdateProjectDto { get; set; }
    }
}
