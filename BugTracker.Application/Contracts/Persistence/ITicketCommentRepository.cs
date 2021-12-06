using BugTracker.Domain.Entities;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface ITicketCommentRepository : IGenericRepository<TicketComment>
    {
    }
}
