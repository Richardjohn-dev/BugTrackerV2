using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.TicketStatus
{
    public class TicketStatusDto : BaseDto, ITicketStatusDto
    {
        public string Status { get; set; }
    }
}
