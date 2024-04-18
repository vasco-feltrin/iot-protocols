using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal class VirtualCar : ISensor,ICar
    {
        public string EndPoint =>Conf.CarId.ToString();

        private VirtualSpeedSensor SpeedSensor => new VirtualSpeedSensor();

        private VirtualGpsSensor GpsSensor => new VirtualGpsSensor();

        private VirtualEngineTemperatureSensor EngineTemperatureSensor => new VirtualEngineTemperatureSensor();

        private VirtualGyroscopeSensor GyroscopeSensor => new  VirtualGyroscopeSensor();

        public CarModel GetData()
        {
            return new CarModel() { EngineTemperatureSensor=EngineTemperatureSensor.Temperature(), GpsSensor= GpsSensor.Position(), GyroscopeSensor=GyroscopeSensor.Rotation(), SpeedSensor=SpeedSensor.Speed(), Id=Conf.CarId};
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(GetData());
        }
    }
}
