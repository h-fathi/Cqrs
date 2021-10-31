using MediatR;

namespace Hf.Cqrs.Infrastructure.Commands
{
    public interface ICommand : ICommand<Result>
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult> where TResult : Result
    {
    }
}