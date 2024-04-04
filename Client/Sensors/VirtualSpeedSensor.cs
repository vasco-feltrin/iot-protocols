using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualSpeedSensor : ISpeedSensor, ISensor
    {
        private readonly Random Random;

        public VirtualSpeedSensor()
        {
            Random = new Random();
        }

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
