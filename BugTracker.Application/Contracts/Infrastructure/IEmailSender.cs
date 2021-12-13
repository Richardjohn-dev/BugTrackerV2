using BugTracker.Application.Models;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
