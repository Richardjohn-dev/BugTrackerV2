using AutoMapper;
using BugTracker.Application.DTOs.Project;
using BugTracker.Application.Features.Projects.Requests.Queries;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Handlers.Queries
{
    public class GetProjectRequestHandler : IRequestHandler<GetProjectRequest, CreateProjectDto>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectRequestHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }  

        public async Task<CreateProjectDto> Handle(GetProjectRequest request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetAsync(request.Id);
            return _mapper.Map<CreateProjectDto>(project);
        }
    }
}
