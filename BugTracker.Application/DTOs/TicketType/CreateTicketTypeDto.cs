using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketType
{
    public class CreateTicketTypeDto : ITicketTypeDto
    {
        public string Type { get; set; }
    }
}
