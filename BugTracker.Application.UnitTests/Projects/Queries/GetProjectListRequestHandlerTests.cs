using AutoMapper;
using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.DTOs.Project;
using BugTracker.Application.Features.Projects.Handlers.Queries;
using BugTracker.Application.Features.Projects.Requests.Queries;
using BugTracker.Application.Profiles;
using BugTracker.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BugTracker.Application.UnitTests.Projects.Queries
{
    public class GetProjectListRequestHandlerTests
    {
        private readonly Mock<IProjectRepository> _mockRepo;
        private readonly IMapper _mapper;
        public GetProjectListRequestHandlerTests()
        {
            _mockRepo = MockProjectRepository.GetProjectRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfiles>();
            });
            _mapper = mapperConfig.CreateMapper();
        }

        // xunit
        [Fact]
        public async Task GetProjectListTest()
        {
            var handler = new GetProjectListRequestHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetProjectListRequest(), CancellationToken.None);

            result.ShouldBeOfType<List<ProjectDto>>();

            result.Count.ShouldBe(2);        
        }

        
    }
}
