using System;
using System.Collections.Generic;
using System.Text;

namespace HalmolenCA.Application.Interfaces.Messaging
{
    public interface ICommand { }
    public interface ICommand<out TResult> : ICommand { }
}
