using Microsoft.AspNetCore.Mvc;

namespace KeepAlive.Controllers
{
    [ApiController]
    public class KeepAlive : ControllerBase
    {
        [HttpGet, Route("keep-alive")]
        public IActionResult KeepAliveGet()
        {
            return Ok();
        }
    }
}