using Hf.Cqrs.Infrastructure;
using Hf.Cqrs.Infrastructure.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hf.Cqrs.Application
{
    public class ProjectQueryHandler : IQueryHandler<ProjectQuery, Result>
    {

        public ProjectQueryHandler()
        {
           //get repository
        }


        public Task<Result> Handle(ProjectQuery request, CancellationToken cancellationToken)
        {
            // do something
            return Task.FromResult(Result.Ok());
        }
    }
}
