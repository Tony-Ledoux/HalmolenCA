using System;
using System.Collections.Generic;
using System.Text;

namespace HalmolenCA.Application.Interfaces.Messaging
{
    public interface IComandHandler<in TCommand> where TCommand : ICommand
    {
        public Task HandleAsync(TCommand command, CancellationToken ct);
    }
    public interface IComandHandler<in TCommand, TResult> where TCommand : ICommand<TResult>
    {
        public Task<TResult> HandleAsync(TCommand command, CancellationToken ct);
    }
}
