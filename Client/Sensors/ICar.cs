using Models;

namespace NetCoreClient.Sensors;

internal interface ICar
{
    CarModel GetData();
    //VirtualSpeedSensor SpeedSensor {  get; }
    //VirtualGpsSensor GpsSensor { get; }
    //VirtualEngineTemperatureSensor EngineTemperatureSensor { get; }
    //VirtualGyroscopeSensor GyroscopeSensor { get; }   
}