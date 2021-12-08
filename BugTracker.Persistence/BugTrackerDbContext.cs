using BugTracker.Domain.Entities;
using BugTracker.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Persistence
{
    public class BugTrackerDbContext : IdentityDbContext<BTUser>
    {
        public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options)
        {
        }
 

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.UtcNow;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TicketStatus> TicketStatuses{ get; set; }
        public DbSet<TicketPriority> TicketPriorities { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }
        public DbSet<Project> Projects { get; set; }
        //  public DbSet<BTUser> Projects { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(BugTrackerDbContext).Assembly);

            builder.Entity<TicketComment>()
                .HasOne(t => t.Ticket)
                .WithMany(tc => tc.TicketComments)
                .HasForeignKey(t => t.TicketId);

            //builder.Entity<Ticket>()
            //   .HasOne(p => p.Project)
            //   .WithMany(t => t.Tickets)
            //   .HasForeignKey(p => p.ProjectId);
        }
    }
   
}
