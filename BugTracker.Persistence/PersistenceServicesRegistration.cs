using BugTracker.Application.Contracts.Persistence;
using BugTracker.Persistence;
using BugTracker.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BugTrackerDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("LeaveManagementConnectionString")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
            services.AddScoped<ITicketStatusRepository, TicketStatusRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            
            services.AddScoped<ITicketAttachmentRepository, TicketAttachmentRepository>();
            services.AddScoped<ITicketCommentRepository, TicketCommentRepository>();
            services.AddScoped<ITicketHistoryRepository, TicketHistoryRepository>();
            services.AddScoped<ITicketPriorityRepository, TicketPriorityRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();

            return services;
        }
    }
}
