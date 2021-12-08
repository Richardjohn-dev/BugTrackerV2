using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Requests.Commands
{
    public class DeleteProjectCommand : IRequest
    {
        public int Id { get; set; }
    }
}
