using BugTracker.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Entities
{
    public class ProjectPriority : BaseDomainEntity
    {
        public string Priority { get; set; }
    }
}
