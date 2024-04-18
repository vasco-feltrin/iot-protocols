using Models;

namespace NetCoreClient.Sensors;

internal interface ITemperatureSensor:ISensor
{
    TemperatureSensorModel Temperature();
}