using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Persistence
{
    public interface IUserRolesRepository
    {
        public Task<bool> IsUserInRoleAsync(ApplicationUser user, string role);
        public Task<IEnumerable<string>> GetUserRolesAsync(ApplicationUser user);
        public Task<bool> AddUserToRoleAsync(ApplicationUser user, string role);
        public Task<bool> RemoveUserFromRoleAsync(ApplicationUser user, string role);
        public Task<bool> RemoveUserFromRolesAsync(ApplicationUser user, IEnumerable<string> roles);
        public Task<string> GetRoleNameByIdAsync(string roleId);

    }
}
