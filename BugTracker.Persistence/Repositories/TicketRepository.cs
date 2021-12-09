using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        private readonly BugTrackerDbContext _dbContext;

        public TicketRepository(BugTrackerDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AssignTicketAsync(int ticketId, string userId)
        {
            var ticket = await _dbContext.Tickets.FirstOrDefaultAsync(x => x.Id == ticketId);
            if (ticket is not null)
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
                if (user is not null)
                {
                    ticket.AssigneeUser = user;
                    await _dbContext.SaveChangesAsync();                   
                }
            }
        }

        public async Task<List<Ticket>> GetProjectTicketsWithDetails(int projectId)
        {
            var tickets = await _dbContext.Tickets                
                 .Include(p => p.AssigneeUser)
                 .Include(p => p.OwnerUser)
                 .Include(p => p.TicketStatus)
                 .Include(p => p.TicketPriority)
                 .Include(p => p.TicketType)
                 .Include(p => p.Project)
                 .Include(p => p.TicketComments)
                 .Include(p => p.TicketAttachments)
                 .Include(p => p.TicketComments)
                 .Where(p => p.ProjectId == projectId)
                 .ToListAsync();

            return tickets;
        }

        public async Task<List<Ticket>> GetUserTicketsWithDetailsAsync(string userId)
        {
            var tickets = await _dbContext.Tickets
                  .Include(p => p.AssigneeUser)
                  .Include(p => p.OwnerUser)
                  .Include(p => p.TicketStatus)
                  .Include(p => p.TicketPriority)
                  .Include(p => p.TicketType)
                  .Include(p => p.Project)
                  .Include(p => p.TicketComments)
                  .Include(p => p.TicketAttachments)
                  .Include(p => p.TicketComments)
                  .Where(p => p.OwnerUser.Id == userId)
                  .ToListAsync();

            return tickets;
        }
    }
}
