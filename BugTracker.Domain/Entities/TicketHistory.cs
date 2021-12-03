using System;
using System.ComponentModel;

namespace BugTracker.Domain.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }      

        [DisplayName("Ticket")]
        public string TicketId { get; set; }

        [DisplayName("Updated Item")]
        public string ItemModified { get; set; }

        [DisplayName("Previous")]
        public string OldValue { get; set; }

        [DisplayName("Current")]
        public string NewValue { get; set; }

        [DisplayName("Date Modified")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Comments")]
        public string Comments { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        // navigation properties at the end or later
       public virtual Ticket Ticket { get; set; }
       // public virtual BTUser User { get; set; }
    }
}
