using AutoMapper;
using BugTracker.Application.DTOs.Project;
using BugTracker.Application.Features.Projects.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Handlers.Queries
{
    public class GetProjectListRequestHandler : IRequestHandler<GetProjectListRequest, List<CreateProjectDto>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectListRequestHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        public async Task<List<CreateProjectDto>> Handle(GetProjectListRequest request, CancellationToken cancellationToken)
        {
            var projects = await _projectRepository.GetAllAsync();
            return _mapper.Map<List<CreateProjectDto>>(projects);
        }
    }
}
