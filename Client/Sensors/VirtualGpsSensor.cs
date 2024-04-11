using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualGpsSensor : IGpsSensor
    {
        private readonly Random Random;

        public VirtualGpsSensor()
        {
            Random = new Random();
        }

        public string EndPoint => "/position";

        public GpsSensorModel Position()
        {
            return new GpsSensorModel() { Altitude = Random.NextDouble(), Latitude = Random.NextDouble(), Longitude = Random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Id=Conf.GpsSensorId };
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Position());
        }
        
    }
}
