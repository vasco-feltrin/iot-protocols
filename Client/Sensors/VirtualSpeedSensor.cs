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
        public string EndPoint => "/speed";

        public SpeedSensorModel Speed()
        {
            var speed = new SpeedSensorModel() { KilometersPerHour = Random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),Id=Guid.Parse("CA09AB32-DF42-4770-AF34-736A44AF3D89") };

            return speed;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Speed());
        }
    }
}
