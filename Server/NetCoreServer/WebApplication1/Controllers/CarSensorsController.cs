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
        public IActionResult SaveSpeedData(int carId, [FromBody] SpeedSensorModel speedData)
        {
            Console.WriteLine(carId + " --- " + speedData);
            return Ok();
        }

        [HttpPost("{carId}/rotation")]
        public IActionResult SaveRotationData(int carId, [FromBody] GyroscopeModel rotationData)
        {
            Console.WriteLine(carId + " --- " + rotationData);
            return Ok();
        }

        [HttpPost("{carId}/position")]
        public IActionResult SavePositionData(int carId, [FromBody] GpsSensorModel gpsData)
        {
            Console.WriteLine($"Position: {carId} --- {gpsData}");
            return Ok();
        }

        [HttpPost("{carId}/temperature")]
        public IActionResult SaveTemperatureData(int carId, [FromBody] EngineTemperatureSensorModel tempData)
        {
            Console.WriteLine($"Temperature: {carId} --- {tempData}");
            return Ok();
        }
    }
}