using BugTracker.Domain.Entities.Common;
using System.ComponentModel;

namespace BugTracker.Domain.Entities
{
    public class TicketComment : UserTicketEntity
    {
        [DisplayName("Comment")]
        public string Comment { get; set; }
    }
}
