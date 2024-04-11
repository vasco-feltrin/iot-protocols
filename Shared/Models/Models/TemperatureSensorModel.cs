namespace Models;

public class TemperatureSensorModel
{
    public long Time { get; set; }

    public required double Celsius { get; set; }
}