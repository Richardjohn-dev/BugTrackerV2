using BugTracker.Domain.Entities;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
    }
}
