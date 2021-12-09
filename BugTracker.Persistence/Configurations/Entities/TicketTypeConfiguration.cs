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
    public class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.HasData(
                new TicketType
                {
                    Id = 1,
                    Type = "Bug"
                },
                new TicketType
                {
                    Id = 2,
                    Type = "Task"
                },
                new TicketType
                {
                    Id = 3,
                    Type = "Improvement"
                }
            );
        }
    }
}
