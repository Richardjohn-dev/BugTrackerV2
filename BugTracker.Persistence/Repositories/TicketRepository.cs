using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(BugTrackerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
