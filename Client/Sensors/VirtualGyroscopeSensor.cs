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
        public string EndPoint => "";

        public GyroscopeModel Rotation()
        {
            return new GyroscopeModel() { XAxis=Random.NextDouble(), YAxis=Random.NextDouble(), ZAxis=Random.NextDouble() };
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Rotation());
        }
    }
}
