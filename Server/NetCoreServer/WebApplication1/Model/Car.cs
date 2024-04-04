using Models;

namespace WebApplication1.Model
{
    public class Car
    {
        public required Guid Id { get; set; }
        public required GpsSensorModel Gps { get; set; }
        public required SpeedSensorModel Speed { get; set; }
        public required TemperatureSensorModel Temperature { get; set; }
        public required GyroscopeModel Gyroscope { get; set; }
    }
}
