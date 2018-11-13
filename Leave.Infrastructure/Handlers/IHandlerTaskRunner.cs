using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Handlers.Base
{
    public interface IHandlerTaskRunner
    {
        IHandlerTask Run(Func<Task> runAsync);
    }
}
