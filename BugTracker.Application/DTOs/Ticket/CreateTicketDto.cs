using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Ticket
{
    public class CreateTicketDto : ITicketDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }


        public string AssigneeUserId { get; set; }
        public string ReporterUserId { get; set; }
       // public string CreatedByUserUserId { get; set; }
      
    }
}
