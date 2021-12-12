using AutoMapper;
using BugTracker.Application.Features.Projects.Requests.Commands;
using BugTracker.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BugTracker.Application.DTOs.Project.Validators;
using BugTracker.Application.Exceptions;

namespace BugTracker.Application.Features.Projects.Handlers.Commands
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var validator = new ProjectDtoValidator();
            var validationResults = await validator.ValidateAsync(request.ProjectDto, cancellationToken);
            if (validationResults.IsValid == false)
                throw new ValidationException(validationResults);

            var project = await _projectRepository.GetAsync(request.ProjectDto.Id);
            _mapper.Map(request.ProjectDto, project);
            await _projectRepository.UpdateAsync(project);
            return Unit.Value;
        }
    }
}
