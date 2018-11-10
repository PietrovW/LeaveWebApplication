using Leave.Infrastructure.Commands.Base;
using Leave.Infrastructure.Commands.Furloughs;
using System;
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
