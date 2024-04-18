using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors;

internal class VirtualSpeedSensor : ISpeedSensor
{
    private readonly Random _random = new();

    public string EndPoint => "/speed";

    public SpeedSensorModel Speed()
    {
        var speed = new SpeedSensorModel() { KilometersPerHour = _random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),Id=Conf.SpeedSensorId };

        return speed;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Speed());
    }
}