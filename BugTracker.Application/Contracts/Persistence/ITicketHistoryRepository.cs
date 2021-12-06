using BugTracker.Domain.Entities;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface ITicketHistoryRepository : IGenericRepository<TicketHistory>
    {
    }
}
