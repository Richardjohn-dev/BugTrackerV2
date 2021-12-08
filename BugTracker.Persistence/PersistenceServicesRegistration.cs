using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using BugTracker.Persistence;
using BugTracker.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
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
                   configuration.GetConnectionString("BugTrackerConnectionString")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
            services.AddScoped<ITicketStatusRepository, TicketStatusRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            
            services.AddScoped<ITicketAttachmentRepository, TicketAttachmentRepository>();
            services.AddScoped<ITicketCommentRepository, TicketCommentRepository>();
            services.AddScoped<ITicketHistoryRepository, TicketHistoryRepository>();
            services.AddScoped<ITicketPriorityRepository, TicketPriorityRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();

            services.AddScoped<IUserRolesRepository, UserRolesRepository>();
 
            //services.AddIdentityCore<BTUser, IdentityRole>()
            //  .AddEntityFrameworkStores<BugTrackerDbContext>().AddDefaultTokenProviders();

            ////services.AddIdentityCore<BTUser, IdentityRole>()
            ////    .AddEntityFrameworkStores<BugTrackerDbContext>().AddDefaultTokenProviders();


            //// services.AddIdentityCore<BTUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            ////.AddDefaultUI()
            ////.AddDefaultTokenProviders()
            ////.AddEntityFrameworkStores<ApplicationDbContext>();

            //// var builder = services.AddIdentityCore<BTUser>(u => u.User.RequireUniqueEmail = true);

            //// builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            //// builder.AddEntityFrameworkStores<BugTrackerDbContext>().
            ////AddDefaultUI()


            return services;
        }
    }
}
