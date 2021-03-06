using BugTracker.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.DTOs.Project.Validators
{
    public class CreateProjectDtoValidator : AbstractValidator<CreateProjectDto>
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectDtoValidator(IProjectRepository ProjectRepository)
        {
            _projectRepository = ProjectRepository;

            Include(new IProjectDtoValidator());

            RuleFor(p => p.Name)
                .MustAsync(async (name, token) =>
                {
                    var nameExists = await _projectRepository.Get(t=> t.Name == name);
                    return nameExists == null ? true : false;
                })
                .WithMessage("{PropertyName} already exists.");
        }
    }
}
