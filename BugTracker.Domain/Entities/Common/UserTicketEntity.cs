using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Entities.Common
{
    public abstract class UserTicketEntity : BaseDomainEntity
    {
        [DisplayName("Ticket")]
        public string TicketId { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
