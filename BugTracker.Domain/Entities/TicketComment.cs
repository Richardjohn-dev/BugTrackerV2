using BugTracker.Domain.Entities.Common;
using System.ComponentModel;

namespace BugTracker.Domain.Entities
{
    public class TicketComment : BaseDomainEntity
    {
        [DisplayName("Comment")]
        public string Comment { get; set; }

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
