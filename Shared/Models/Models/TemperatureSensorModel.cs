namespace Models;

public class TemperatureSensorModel
{
    public required Guid Id { get; set; }

    public required long Time { get; set; }

    public required double Celsius { get; set; }
}