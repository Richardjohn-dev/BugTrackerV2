using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketComment
{
    public interface ITicketCommentDto
    {
        public int TicketId { get; set; }
        public string Comment { get; set; }
    }
}
