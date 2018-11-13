using Leave.Infrastructure.Commands.Accounts;
using Leave.Infrastructure.Commands.Base;
using Leave.Infrastructure.Extensions;
using Leave.Infrastructure.Handlers.Base;
using Leave.Infrastructure.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Leave.Infrastructure.Handlers.Accounts
{
    public class LoginHandler : ICommandHandler<Login>
    {
        private readonly IHandler _handler;
        private readonly IEmployeService _employeService;
        private readonly IJwtHandler _jwtHandler;
        private readonly IMemoryCache _cache;

        public LoginHandler(IHandler handler, IEmployeService employeService,
                            IJwtHandler jwtHandler, IMemoryCache cache)
        {
            _handler = handler;
            _employeService = employeService;
            _jwtHandler = jwtHandler;
            _cache = cache;
        }

        public async Task HandleAsync(Login command)
        => await _handler
            .Run(async () => await _employeService.LoginAsync(command.Email, command.Password))
            .Next()
            .Run(async () =>
            {
                var user = await _employeService.GetByEmailAsync(command.Email);
                var jwt = _jwtHandler.CreateToken(user.Id, user.Role);
                _cache.SetJwt(command.TokenId, jwt);
            })
            .Next()
            .ExecuteAllAsync();
    }
}