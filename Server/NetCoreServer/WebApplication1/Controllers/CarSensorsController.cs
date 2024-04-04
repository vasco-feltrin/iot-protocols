using Microsoft.AspNetCore.Mvc;
using Models;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarSensorsController(ILogger<CarSensorsController> logger) : ControllerBase
    {
        private readonly ILogger<CarSensorsController> _logger = logger;

        [HttpPost("{carId}/speed")]
        public IActionResult SaveSpeedData(Guid carId, [FromBody] SpeedSensorModel speedData)
        {
            Console.WriteLine(carId + " --- " + speedData);
            return Ok();
        }

        [HttpPost("{carId}/rotation")]
        public IActionResult SaveRotationData(Guid carId, [FromBody] GyroscopeModel rotationData)
        {
            Console.WriteLine(carId + " --- " + rotationData);
            return Ok();
        }

        [HttpPost("{carId}/position")]
        public IActionResult SavePositionData(Guid carId, [FromBody] GpsSensorModel gpsData)
        {
            Console.WriteLine($"Position: {carId} --- {gpsData}");
            return Ok();
        }

        [HttpPost("{carId}/temperature")]
        public IActionResult SaveTemperatureData(Guid carId, [FromBody] TemperatureSensorModel tempData)
        {
            Console.WriteLine($"Temperature: {carId} --- {tempData}");
            return Ok();
        }

        [HttpGet("{carId}")]
        public IEnumerable<Car> GetCar(int carId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Ottine la lista degli Id di tutte le macchine
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public IEnumerable<Guid> GetCarList()
        {
            throw new NotImplementedException();
        }
    }
}