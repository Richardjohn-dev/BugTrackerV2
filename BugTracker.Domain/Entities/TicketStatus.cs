using BugTracker.Domain.Entities.Common;

namespace BugTracker.Domain.Entities
{
    public class TicketStatus : BaseDomainEntity
    {       
        public string Status { get; set; }
    }
}
