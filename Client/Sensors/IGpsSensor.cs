using Models;

namespace NetCoreClient.Sensors;

internal interface IGpsSensor: ISensor
{
    GpsSensorModel Position();
}