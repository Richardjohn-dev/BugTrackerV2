using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketStatus
{
    public class CreateTicketStatusDto : ITicketStatusDto
    {
        public string Status { get; set; }
    }
}
