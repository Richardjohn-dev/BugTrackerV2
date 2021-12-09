using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.LeaveManagement.Persistence.Configurations.Entities
{
    public class TicketStatusConfiguration : IEntityTypeConfiguration<TicketStatus>
    {
        public void Configure(EntityTypeBuilder<TicketStatus> builder)
        {
            builder.HasData(
                new TicketStatus
                {
                    Id = 1,
                    Status = "Unassigned",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketStatus
                {
                    Id = 2,
                    Status = "Draft",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketStatus
                {
                    Id = 3,
                    Status = "In Progress",
                    DateCreated = DateTimeOffset.UtcNow
                },
                  new TicketStatus
                  {
                      Id = 4,
                      Status = "Resolved",
                      DateCreated = DateTimeOffset.UtcNow
                  },
                new TicketStatus
                {
                    Id = 5,
                    Status = "Closed",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketStatus
                {
                    Id = 6,
                    Status = "Reopened",
                    DateCreated = DateTimeOffset.UtcNow
                }
            );
        }
    }
}
