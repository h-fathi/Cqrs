using Hf.Cqrs.Infrastructure;
using Hf.Cqrs.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hf.Cqrs.Application
{
    public class ProjectCommandHandler : ICommandHandler<DeleteProjectCommand, Result>,
       ICommandHandler<CreateProjectCommand, Result>
    {

        public ProjectCommandHandler()
        {
           
        }

        public Task<Result> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            // do something
            return Task.FromResult(Result.Ok());
        }

        public Task<Result> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
