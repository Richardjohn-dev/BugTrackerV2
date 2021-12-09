using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class UserRolesRepository : IUserRolesRepository
    {
        private readonly BugTrackerDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRolesRepository(
            BugTrackerDbContext dbContext, 
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<bool> AddUserToRoleAsync(ApplicationUser user, string role)
            => (await _userManager.AddToRoleAsync(user, role)).Succeeded;
      
        public async Task<string> GetRoleNameByIdAsync(string roleId)
        {
            var role = _dbContext.Roles.Find(roleId);
            string result = await _roleManager.GetRoleNameAsync(role);
            return result;
        }

        public async Task<IEnumerable<string>> GetUserRolesAsync(ApplicationUser user) 
            => await _userManager.GetRolesAsync(user);

        public async Task<bool> IsUserInRoleAsync(ApplicationUser user, string role) 
            => await _userManager.IsInRoleAsync(user, role);
       

        public async Task<bool> RemoveUserFromRoleAsync(ApplicationUser user, string role) 
            => (await _userManager.RemoveFromRoleAsync(user, role)).Succeeded;

        public async Task<bool> RemoveUserFromRolesAsync(ApplicationUser user, IEnumerable<string> roles)
            => (await _userManager.RemoveFromRolesAsync(user, roles)).Succeeded;
    }
}
