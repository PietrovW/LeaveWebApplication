using Leave.Api.Controllers.Base;
using Leave.Infrastructure.Commands.Base;
using Leave.Infrastructure.Commands.Furloughs;
using Leave.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave.Api.Controllers
{
    public class FurloughsController : ApiControllerBase
    {
        private readonly IFurloughService _furloughsService;
        public FurloughsController(ICommandDispatcher commandDispatcher, IFurloughService furloughsService) : base(commandDispatcher)
        {
            _furloughsService = furloughsService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var furloughs = await _furloughsService.AllAsync();

            return Json(furloughs);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            var furloughs = await _furloughsService.FindByIdAsync(userId);
            if (furloughs == null)
            {
                return NotFound();
            }

            return Json(furloughs);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateFurlough command)
        {
            await DispatchAsync(command);

            return Created($"drivers/{command.UserId}", null);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateFurlough command)
        {
            await DispatchAsync(command);

            return NoContent();
        }

        [Authorize]
        [HttpDelete("me")]
        public async Task<IActionResult> Delete()
        {
            await DispatchAsync(new DeleteFurlough());

            return NoContent();
        }
    }

}
