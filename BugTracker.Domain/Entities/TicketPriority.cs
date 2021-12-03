using BugTracker.Domain.Entities.Common;

namespace BugTracker.Domain.Entities
{
    public class TicketPriority : BaseDomainEntity
    {
        public string Priority { get; set; }
    }
}
