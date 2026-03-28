/*using Microsoft.AspNetCore.Mvc;
using DroneX_API.Models;
using DroneX_API.Services;

namespace DroneX_API.Controllers
{
    [ApiController]
    [Route("api/performance")]
    public class PerformanceController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;

        public PerformanceController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        [HttpPost("save")]
        public async Task<IActionResult> SavePerformance([FromBody] PerformanceLog log)
        {
            await _mongoDbService.SavePerformance(log);

            return Ok("Performance Saved Successfully");
        }
    }
}*/

/*using Microsoft.AspNetCore.Mvc;
using DroneX_API.Models;
using DroneX_API.Services;

namespace DroneX_API.Controllers
{
    [ApiController]
    [Route("api/performance")]
    public class PerformanceController : ControllerBase
    {
        private readonly MongoDbService _mongo;

        public PerformanceController(MongoDbService mongo)
        {
            _mongo = mongo;
        }

        [HttpPost("save")]
        public IActionResult SavePerformance([FromBody] PerformanceLog log)
        {
            _mongo.SavePerformance(log);

            return Ok("Performance saved successfully");
        }
    }
}*/
using Microsoft.AspNetCore.Mvc;
using DroneX_API.Models;
using DroneX_API.Services;

namespace DroneX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerformanceController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;

        public PerformanceController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        // ✅ SAVE DATA
        [HttpPost]
        public IActionResult SavePerformance([FromBody] PerformanceLog log)
        {
            _mongoDbService.Insert(log);
            return Ok(new { message = "Data Saved Successfully" });
        }

        // ✅ GET ALL DATA (Leaderboard)
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _mongoDbService.GetAll();
            return Ok(data);
        }
    }
}