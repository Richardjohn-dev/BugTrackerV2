using BugTracker.Application.DTOs.Common;


namespace BugTracker.Application.DTOs.TicketComment
{
    public class TicketCommentDto : BaseDto, ITicketCommentDto
    {
        public string Comment { get; set; }
        public int TicketId { get; set; }
    }
}
