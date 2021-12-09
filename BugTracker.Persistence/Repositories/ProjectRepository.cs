using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly BugTrackerDbContext _dbContext;
        private readonly UserRolesRepository _userRolesRepository;

        public ProjectRepository(BugTrackerDbContext dbContext, UserRolesRepository userRolesRepository) : base(dbContext)
        {
            _dbContext = dbContext;
            _userRolesRepository = userRolesRepository;
        }
    
       public async Task<bool> AddUserToProjectAsync(string userId, int projectId)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
                if (user is not null)
                {
                    var project = await _dbContext.Projects.FirstOrDefaultAsync(p => p.Id == projectId);
                    project.Members.Add(user);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {               
               
            }
            return false;
        }

   

        public async Task<List<ApplicationUser>> GetProjectUsersAsync(int projectId)
        {
            return (await _dbContext.Projects.Include(u => u.Members).FirstOrDefaultAsync(p => p.Id == projectId)).Members.ToList();
        }

        public async Task<List<ApplicationUser>> GetProjectUsersByRoleAsync(int projectId, string role)
        {
           List<ApplicationUser> output = new();
           var project = await _dbContext.Projects.Include(p=>p.Members).FirstOrDefaultAsync(p => p.Id == projectId);
            foreach (var user in project.Members)
            {
                if (await _userRolesRepository.IsUserInRoleAsync(user, role))
                {
                    output.Add(user);
                }
            }
            return output;
        }

        public async Task<List<Project>> GetUserProjectsAsync(string userId)
        {
            return (await _dbContext.Users.Include(p => p.Projects).FirstOrDefaultAsync(u => u.Id == userId)).Projects.ToList();
        }
              

       public async Task RemoveUserFromProjectAsync(string userId, int projectId)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
                var project = await _dbContext.Projects.FirstOrDefaultAsync(p => p.Id == projectId);
                project.Members.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
          
        }


        public async Task UpdateCompleted(bool IsComplete, int projectId)
        {
            var project = await _dbContext.Projects.FirstOrDefaultAsync(p => p.Id == projectId);
            project.IsComplete = IsComplete;
            _dbContext.Update(project);
            await _dbContext.SaveChangesAsync();
        }
    }
}
