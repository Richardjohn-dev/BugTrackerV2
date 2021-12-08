using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        public Task<bool> AddProjectManagerAsync(string userId, int projectId);
        public Task RemoveProjectManagerAsync(int projectId);
        public Task<BTUser> GetProjectManagerAsync(int projectId);


        public Task<List<BTUser>> GetProjectDevelopersAsync(int projectId);
        public Task<List<BTUser>> GetProjectMembersByRoleAsync(int projectId, string role);


        public Task<bool> AddUserToProjectAsync(string userId, int projectId);
        public Task RemoveUserFromProjectAsync(string userId, int projectId);
      
    }
}
