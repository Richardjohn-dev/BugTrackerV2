using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class TicketHistoryRepository : GenericRepository<TicketHistory>, ITicketHistoryRepository
    {
        public TicketHistoryRepository(BugTrackerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
