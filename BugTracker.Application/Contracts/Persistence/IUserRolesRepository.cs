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
        public Task<bool> IsUserInRoleAsync(BTUser user, string role);
        public Task<IEnumerable<string>> GetUserRolesAsync(BTUser user);
        public Task<bool> AddUserToRoleAsync(BTUser user, string role);
        public Task<bool> RemoveUserFromRoleAsync(BTUser user, string role);
        public Task<bool> RemoveUserFromRolesAsync(BTUser user, IEnumerable<string> roles);
        public Task<string> GetRoleNameByIdAsync(string roleId);

    }
}
