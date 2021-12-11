using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.TicketType
{
    public class TicketTypeDto : BaseDto, ITicketTypeDto
    {
        public string Type { get; set; }
    }
}
