using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreClient.Sensors;

internal class VirtualEngineTemperatureSensor:ITemperatureSensor
{
    private readonly Random Random;

    public VirtualEngineTemperatureSensor()
    {
        Random = new Random();
    }
    public string EndPoint => "/Temperature";
    public TemperatureSensorModel Temperature()
    {
        return new TemperatureSensorModel() { Celsius = Random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Id = Conf.EngineTemperatureSensorId };
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Temperature());
    }
}