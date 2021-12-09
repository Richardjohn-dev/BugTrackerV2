using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
       // public Task ArchiveTicketAsync(Ticket ticket);
        public Task AssignTicketAsync(int ticketId, string userId);
        public Task<List<Ticket>> GetUserTicketsWithDetailsAsync(string userId);
        public Task<List<Ticket>> GetProjectTicketsWithDetails(int projectId);

        //public Task<List<Ticket>> GetProjectTicketsByStatusAsync(string statusName, int companyId, int projectId);
        //public Task<List<Ticket>> GetProjectTicketsByPriorityAsync(string priorityName, int companyId, int projectId);
    }
}
