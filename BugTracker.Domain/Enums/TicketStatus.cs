using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Enums
{
    public enum TicketStatus
    {
        Unassigned = 1,
        Draft = 2,
        InProgress = 3,
        Resolved = 4,
        Closed = 5,
        Reopened = 6
    }
}
