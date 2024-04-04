using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualTemperatureSensor:ITemperatureSensor
    {
        private readonly Random Random;

        public VirtualTemperatureSensor()
        {
            Random = new Random();
        }

        public TemperatureSensorModel Temperature()
        {
            return new TemperatureSensorModel() { Celsius = Random.NextDouble() };
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Temperature());
        }
    }
}
