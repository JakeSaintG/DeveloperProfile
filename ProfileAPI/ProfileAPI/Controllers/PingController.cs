using Microsoft.AspNetCore.Mvc;
using ProfileAPI.Services;
using ProfileAPI.Models;

namespace ProfileAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {

        [HttpGet(Name = "GetPing")]
        public Ping Get()
        {
            return PingService.ReturnPing();
        }
    }
}
