using MediatR;

namespace Hf.Cqrs.Infrastructure.Commands
{
    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Result> where TCommand : ICommand
    {
    }

    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : ICommand<TResult> where TResult : Result
    {
    }
}