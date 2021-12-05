using BugTracker.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Entities
{
    public class Ticket : BaseDomainEntity
    {
        [Required]
        [StringLength(150)]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("Description")]
        public string Description { get; set; }


       
        [DisplayName("Project")]
        public string ProjectId { get; set; }

        [DisplayName("Type")]
        public string TicketTypeId { get; set; }

        [DisplayName("Priority")]
        public string TicketPriorityId { get; set; }

        [DisplayName("Status")]
        public string TicketStatusId { get; set; }

        [DisplayName("Assigned To")]
        public string AssigneeUserId { get; set; }

        [DisplayName("Owned By")]
        public string OwnerUserId { get; set; }

       // [DisplayName("Created By")]
      //  public string CreatedByUserUserId { get; set; }


        // nav
       // public virtual BTUser CreatedByUser { get; set; }      
        public virtual BTUser OwnerUser { get; set; }
        public virtual BTUser AssigneeUser { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }
        public virtual TicketPriority TicketPriority { get; set; }
        public virtual TicketType TicketType { get; set; }

        public virtual Project Project { get; set; }

        public virtual ICollection<TicketComment> Comments { get; set; } = new HashSet<TicketComment>();
        public virtual ICollection<TicketComment> Attachments { get; set; } = new HashSet<TicketComment>();
        public virtual ICollection<TicketHistory> History { get; set; } = new HashSet<TicketHistory>();

    }
}
