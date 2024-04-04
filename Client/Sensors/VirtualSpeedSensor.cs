using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualSpeedSensor : ISpeedSensor
    {
        private readonly Random Random;

        public VirtualSpeedSensor()
        {
            Random = new Random();
        }
        public string EndPoint => "/0/speed";

        public SpeedSensorModel Speed()
        {
            var speed = new SpeedSensorModel() { KilometersPerHour = Random.NextDouble() };

            return speed;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Speed());
        }
    }
}
