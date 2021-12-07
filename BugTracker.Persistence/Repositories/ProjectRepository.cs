﻿using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly BugTrackerDbContext _dbContext;

        public ProjectRepository(BugTrackerDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }       
    }
}
