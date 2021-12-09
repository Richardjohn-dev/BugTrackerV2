using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
       // public Task<bool> AddProjectManagerAsync(string userId, int projectId);


        public Task<List<ApplicationUser>> GetProjectUsersByRoleAsync(int projectId, string role);
        public Task<List<ApplicationUser>> GetProjectUsersAsync(int projectId);
        public Task<List<Project>> GetUserProjectsAsync(string userId);

        public Task<bool> AddUserToProjectAsync(string userId, int projectId);
        public Task RemoveUserFromProjectAsync(string userId, int projectId);

        public Task UpdateCompleted(bool IsComplete, int projectId);
      
    }
}
