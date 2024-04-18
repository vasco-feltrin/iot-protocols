using Models;
using System.Text.Json;

namespace NetCoreClient.Sensors;

internal class VirtualGpsSensor : IGpsSensor
{
    private readonly Random _random = new();

    public string EndPoint => "/position";

    public GpsSensorModel Position()
    {
        return new GpsSensorModel() { Altitude = _random.NextDouble(), Latitude = _random.NextDouble(), Longitude = _random.NextDouble(), Time = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Id=Conf.GpsSensorId };
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Position());
    }
        
}