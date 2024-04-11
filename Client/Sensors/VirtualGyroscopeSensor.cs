using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualGyroscopeSensor : IGyroscopeSensor
    {
        private readonly Random Random;

        public VirtualGyroscopeSensor()
        {
            Random = new Random();
        }
        public string EndPoint => "/rotation";

        public GyroscopeModel Rotation()
        {
            return new GyroscopeModel() { XAxis=Random.NextDouble(), YAxis=Random.NextDouble(), ZAxis=Random.NextDouble() , Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),Id=Guid.Parse("8B95D1B7-4931-49C4-89D2-C3C3DF7CDD59") };
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Rotation());
        }
    }
}
