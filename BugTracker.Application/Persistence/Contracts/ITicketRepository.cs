using BugTracker.Domain.Entities;

namespace CleanArchitecture.LeaveManagement.Application.Persistence.Contracts
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
    }
}
