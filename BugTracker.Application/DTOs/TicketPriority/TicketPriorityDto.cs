using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.TicketPriority
{
    public class TicketPriorityDto : BaseDto, ITicketPriorityDto
    {
        public string Priority { get; set; }
    }
}
