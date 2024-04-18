using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors;

internal class VirtualGyroscopeSensor : IGyroscopeSensor
{
    private readonly Random _random = new();

    public string EndPoint => "/rotation";

    public GyroscopeModel Rotation()
    {
        return new GyroscopeModel() { XAxis=_random.NextDouble(), YAxis=_random.NextDouble(), ZAxis=_random.NextDouble() , Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),Id=Conf.SpeedSensorId };
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Rotation());
    }
}