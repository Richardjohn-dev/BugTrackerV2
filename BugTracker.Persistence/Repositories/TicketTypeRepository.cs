using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class TicketTypeRepository : GenericRepository<TicketType>, ITicketTypeRepository
    {
        public TicketTypeRepository(BugTrackerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
