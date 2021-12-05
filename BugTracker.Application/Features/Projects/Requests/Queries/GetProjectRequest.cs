using BugTracker.Application.DTOs.Project;
using MediatR;

namespace BugTracker.Application.Features.Projects.Requests.Queries
{
    public class GetProjectRequest : IRequest<ProjectDto>
    {
        public int Id { get; set; }
    }
}
