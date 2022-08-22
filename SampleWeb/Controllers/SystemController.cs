using Microsoft.AspNetCore.Mvc;

namespace SampleWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : ControllerBase
    {
        public SystemController()
        {

        }

        [HttpGet(Name = "HealthCheck")]
        public IActionResult Get()
        {
#if DEBUG
            return Ok("DEV");
#else
            return Ok("PROD");
#endif

        }
    }
}