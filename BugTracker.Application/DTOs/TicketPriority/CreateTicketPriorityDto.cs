﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketPriority
{
    public class CreateTicketPriorityDto : ITicketPriorityDto
    {
        public string Priority { get; set; }
    }
}
