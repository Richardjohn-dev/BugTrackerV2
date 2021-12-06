using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.Ticket
{
    public class TicketDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
        public string TicketTypeId { get; set; }
        public string TicketPriorityId { get; set; }
        public string TicketStatusId { get; set; }


        public string AssigneeUserId { get; set; }
        public string OwnerUserId { get; set; }
    }
}
