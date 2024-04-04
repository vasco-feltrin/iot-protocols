using Models;

namespace NetCoreClient.Sensors
{
    interface ISpeedSensor: ISensor
    {
        SpeedSensorModel Speed();
    }
}
