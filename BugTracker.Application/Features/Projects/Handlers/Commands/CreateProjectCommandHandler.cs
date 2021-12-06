using AutoMapper;
using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.Features.Projects.Requests.Commands;
using BugTracker.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Handlers.Commands
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public CreateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }   

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _mapper.Map<Project>(request.ProjectDto);
            project = await _projectRepository.AddAsync(project);
            return project.Id;
        }
    }
}
