﻿using CleanArchitecture.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.TicketType
{
    public class TicketStatusDto : BaseDto
    {
        public string Status { get; set; }
    }
}
