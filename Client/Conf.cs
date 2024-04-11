using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient
{
    public static class Conf
    {
        private static IConfigurationRoot conf=new ConfigurationBuilder().AddJsonFile("config.json", optional: false, reloadOnChange: true).Build();
        public static Guid CarId = Guid.Parse(conf["CarId"]);
        public static Guid SpeedSensorId = Guid.Parse(conf["SpeedSensorId"]);
        public static Guid GpsSensorId = Guid.Parse(conf["GpsSensorId"]);
        public static Guid GyroscopeSensorId = Guid.Parse(conf["GyroscopeSensorId"]);
        public static Guid EngineTemperatureSensorId = Guid.Parse(conf["EngineTemperatureSensorId"]);
        

    }
}
