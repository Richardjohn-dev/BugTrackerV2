using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.Project
{
    public class ProjectDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
