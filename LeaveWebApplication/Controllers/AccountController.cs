using Leave.Api.Controllers.Base;
using Leave.Infrastructure.Commands.Base;
using Leave.Infrastructure.Commands.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Leave.Api.Controllers
{
    public class AccountController : ApiControllerBase
    {
        public AccountController(ICommandDispatcher commandDispatcher)
            : base(commandDispatcher)
        {
        }

        [HttpPut]
        [Route("password")]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
        {
            await DispatchAsync(command);

            return NoContent();
        }
    }
}
