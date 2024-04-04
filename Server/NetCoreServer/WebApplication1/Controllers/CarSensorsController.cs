using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarSensorsController(ILogger<CarSensorsController> logger) : ControllerBase
    {
        private readonly ILogger<CarSensorsController> _logger = logger;

        [HttpPost("{carId}/speed")]
        public IActionResult SaveSpeedData([FromBody] SpeedSensorModel speed)
        {
            Console.WriteLine( /*carId + */" --- " + speed);
            return Ok();
        }
    }
}