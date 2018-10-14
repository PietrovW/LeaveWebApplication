using Leave.Infrastructure.Commands.Furloughs;
using Leave.Infrastructure.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Handlers.Furloughs
{
    public class CreateFurloughHandler : ICommandHandler<CreateFurlough>
    {
        public Task HandleAsync(CreateFurlough command)
        {
            throw new NotImplementedException();
        } 
    }
}
