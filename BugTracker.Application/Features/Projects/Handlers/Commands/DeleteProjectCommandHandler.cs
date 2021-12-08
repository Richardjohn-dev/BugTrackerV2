using BugTracker.Application.Contracts.Persistence;
using BugTracker.Application.Features.Projects.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Handlers.Commands
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;
       

        public DeleteProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
          
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            // what about tickets in this project? 
            // can be custom rules, remove project but orphan tickets inside this project?
            // cannot delete project with active tickets more likely..
            var project = await _projectRepository.GetAsync(request.Id);
            await _projectRepository.DeleteAsync(project);
            return Unit.Value;
        }
    }
}
