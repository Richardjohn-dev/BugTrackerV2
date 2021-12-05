using BugTracker.Application.DTOs.Project;
using MediatR;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects.Requests.Queries
{
    public class GetProjectListRequest : IRequest<List<CreateProjectDto>>
    {
        
    }
}
