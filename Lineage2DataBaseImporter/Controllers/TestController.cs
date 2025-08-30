using Lineage2DataBaseImporter.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lineage2DataBaseImporter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly ISkillReaderService _skillReaderService;

        public TestController(ISkillReaderService skillReaderService, ILogger<TestController> logger)
        {
            _skillReaderService = skillReaderService;
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public IActionResult Get(CancellationToken ct)
        {
            _logger.LogInformation("TestController Get method called.");
            _skillReaderService.StartAsync(ct);
            return Ok("TestController is working!");
        }
    }
}
