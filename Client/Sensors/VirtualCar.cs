using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors;

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