using System.Text.Json;
using Models;

namespace NetCoreClient.Sensors;

internal class VirtualSpeedSensor : ISpeedSensor
{
    private readonly Random _random = new();

    public string EndPoint => "/speed";

    public SpeedSensorModel Speed()
    {
        SpeedSensorModel speed = new()
        {
            KilometersPerHour = _random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
            Id = Conf.SpeedSensorId
        };

        return speed;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Speed());
    }
}