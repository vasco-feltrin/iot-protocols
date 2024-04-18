using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors
{
    internal interface ICar
    {
        CarModel GetData(); 
        //VirtualSpeedSensor SpeedSensor {  get; }
        //VirtualGpsSensor GpsSensor { get; }
        //VirtualEngineTemperatureSensor EngineTemperatureSensor { get; }
        //VirtualGyroscopeSensor GyroscopeSensor { get; }   
    }
}
