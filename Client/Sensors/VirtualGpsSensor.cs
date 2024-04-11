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
            return new GpsSensorModel() { Altitude = Random.NextDouble(), Latitude = Random.NextDouble(), Longitude = Random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Id=Guid.Parse("ED7D07DD-218B-484A-A030-82B160F453B0") };
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Position());
        }
        
    }
}
