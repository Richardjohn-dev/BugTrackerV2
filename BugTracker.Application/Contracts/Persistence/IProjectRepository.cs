using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        
    }
}
