using BugTracker.Application.DTOs.Common;

namespace BugTracker.Application.DTOs.Ticket
{
    public class TicketDto : BaseDto, ITicketDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }

        // this should have all the models etc for 'get ticket with details'

        public string AssigneeUserId { get; set; }
        public string ReporterUserId { get; set; }
    }
}
