using System.Threading;
using System.Threading.Tasks;
using Hf.Cqrs.Infrastructure.Commands;
using MediatR;

namespace Hf.Cqrs.Infrastructure.Behaviors
{
    public class RetryBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : ICommand
        where TResponse : Result
    {
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            throw new System.NotImplementedException();
        }
    }
}