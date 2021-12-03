using CleanArchitecture.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketComment
{
    public class TicketCommentDto : BaseDto
    {
        public string Comment { get; set; }
    }
}
