using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Project
{
    public interface IProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
