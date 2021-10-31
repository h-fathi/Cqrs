using MediatR;

namespace Hf.Cqrs.Infrastructure.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}
