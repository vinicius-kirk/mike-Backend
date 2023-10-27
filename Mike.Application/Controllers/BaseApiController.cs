using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mike.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize("Bearer")]
    public class BaseApiController : ControllerBase
    {
        protected readonly ILogger<BaseApiController> _logger;

        public BaseApiController(ILogger<BaseApiController> logger)
        {
            _logger = logger;
        }
    }
}
