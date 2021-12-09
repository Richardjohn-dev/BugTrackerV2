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
    public class TicketPriorityConfiguration : IEntityTypeConfiguration<TicketPriority>
    {
        public void Configure(EntityTypeBuilder<TicketPriority> builder)
        {
            builder.HasData(
                new TicketPriority
                {
                    Id = 1,
                    Priority = "Trivial",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketPriority
                {
                    Id = 2,
                    Priority = "Low",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketPriority
                {
                    Id = 3,
                    Priority = "Medium",
                    DateCreated = DateTimeOffset.UtcNow
                },
                  new TicketPriority
                  {
                      Id = 4,
                      Priority = "High",
                      DateCreated = DateTimeOffset.UtcNow
                  },
                new TicketPriority
                {
                    Id = 5,
                    Priority = "Critical",
                    DateCreated = DateTimeOffset.UtcNow
                },
                new TicketPriority
                {
                    Id = 6,
                    Priority = "Blocker",
                    DateCreated = DateTimeOffset.UtcNow
                }
            );
        }
    }
}
