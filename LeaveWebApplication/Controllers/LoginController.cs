using Leave.Api.Controllers.Base;
using Leave.Infrastructure.Commands.Accounts;
using Leave.Infrastructure.Commands.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;
using Leave.Infrastructure.Extensions;

namespace Leave.Api.Controllers
{
    public class LoginController : ApiControllerBase
    {
        private readonly IMemoryCache _cache;

        public LoginController(ICommandDispatcher commandDispatcher,
            IMemoryCache cache)
            : base(commandDispatcher)
        {
            _cache = cache;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Login command)
        {
            command.TokenId = Guid.NewGuid();
            await DispatchAsync(command);
            var jwt = _cache.GetJwt(command.TokenId);

            return Json(jwt);
        }
    }
}
