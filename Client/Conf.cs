using Microsoft.Extensions.Configuration;

namespace NetCoreClient;

public static class Conf
{
    private static readonly IConfigurationRoot conf = new ConfigurationBuilder().AddJsonFile("config.json", optional: false, reloadOnChange: true).Build();
    public static Guid CarId = Guid.Parse(conf["CarId"]);
    public static Guid SpeedSensorId = Guid.Parse(conf["SpeedSensorId"]);
    public static Guid GpsSensorId = Guid.Parse(conf["GpsSensorId"]);
    public static Guid GyroscopeSensorId = Guid.Parse(conf["GyroscopeSensorId"]);
    public static Guid EngineTemperatureSensorId = Guid.Parse(conf["EngineTemperatureSensorId"]);
    public static string ServerHttpUrl = conf["ServerHttpUrl"];
    public static readonly string BrokerMqttUrl = conf["BrokerMqttUrl"];

}