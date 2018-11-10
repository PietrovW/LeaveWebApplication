using System;

namespace Leave.Infrastructure.Commands.Authenticated
{
    public class AuthenticatedCommandBase : IAuthenticatedCommand
    {
        public Guid UserId { get; set; }
    }
}
