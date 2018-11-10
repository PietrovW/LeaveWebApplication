using Leave.Infrastructure.Commands.Base;
using System;

namespace Leave.Infrastructure.Commands.Authenticated
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid UserId { get; set; }
    }
}
