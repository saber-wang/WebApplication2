using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<TestController>();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            throw new Exception();
            return new { test = "1.0" };
        }

    }
}