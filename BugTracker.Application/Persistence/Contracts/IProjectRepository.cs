using BugTracker.Domain.Entities;
using CleanArchitecture.LeaveManagement.Application.Persistence.Contracts;

namespace BugTracker.Application.Persistence.Contracts
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        
    }
}
