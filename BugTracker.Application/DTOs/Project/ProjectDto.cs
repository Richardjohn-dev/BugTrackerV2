﻿using CleanArchitecture.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Project
{
    public class ProjectDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
