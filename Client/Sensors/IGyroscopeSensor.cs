using Models;

namespace NetCoreClient.Sensors;

internal interface IGyroscopeSensor:ISensor
{
    GyroscopeModel Rotation();
}