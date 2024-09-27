using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToyValuer.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ToyValuerController : ControllerBase
    {
        private readonly ILogger<ToyValuerController> _logger;

        public ToyValuerController(ILogger<ToyValuerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFundValue")]
        public decimal Get(string folioCode)
        {
            return 0m;
        }
    }
}
