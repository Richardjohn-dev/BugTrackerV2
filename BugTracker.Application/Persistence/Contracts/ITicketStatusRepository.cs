using BugTracker.Domain.Entities;

namespace CleanArchitecture.LeaveManagement.Application.Persistence.Contracts
{
    public interface ITicketStatusRepository : IGenericRepository<TicketStatus>
    {
    }
}
