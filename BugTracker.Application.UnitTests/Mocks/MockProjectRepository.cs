using BugTracker.Application.Contracts.Persistence;
using BugTracker.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.UnitTests.Mocks
{
    public static class MockProjectRepository
    {
        public static Mock<IProjectRepository> GetProjectRepository()
        {
            // need to create a mock repository and return it
            var projectsList = new List<Project>()
            {
                new Project()
                {
                    Id = 1,
                    Name = "First Project",
                    Description = "Project description"
                },
                 new Project()
                {
                    Id = 2,
                    Name = "Second Project",
                    Description = "Project description"
                }
            };

            var singleTest = new Project()
            {
                Id = 1,
                Name = "First Project",
                Description = "Project description"
            };

            var mockProjectRepo = new Mock<IProjectRepository>();
            mockProjectRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(projectsList);

            mockProjectRepo.Setup(r => r.GetAsync(1)).ReturnsAsync(singleTest);

            mockProjectRepo.Setup(r => r.AddAsync(It.IsAny<Project>())).ReturnsAsync((Project project) =>
            {
                projectsList.Add(project);
                return project;
            });

            return mockProjectRepo;
        }
    }
}
