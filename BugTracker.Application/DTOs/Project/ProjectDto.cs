using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.Project
{
    public class ProjectDto : BaseDto, IProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
