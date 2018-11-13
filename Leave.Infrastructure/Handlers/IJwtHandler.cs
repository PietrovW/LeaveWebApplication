using Leave.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.Infrastructure.Handlers
{
    public interface IJwtHandler
    {
        JwtDto CreateToken(Guid userId, string role);
    }
}
