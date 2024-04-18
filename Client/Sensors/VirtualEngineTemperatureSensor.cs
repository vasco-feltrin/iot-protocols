using System.Text.Json;
using Models;

namespace NetCoreClient.Sensors;

internal class VirtualEngineTemperatureSensor : ITemperatureSensor
{
    private readonly Random _random = new();

    public string EndPoint => "/Temperature";

    public TemperatureSensorModel Temperature()
    {
        return new TemperatureSensorModel
        {
            Celsius = _random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
            Id = Conf.EngineTemperatureSensorId
        };
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Temperature());
    }
}