namespace Models;

public class CarModel
{
    public required Guid Id { get; set; }
    public required GpsSensorModel GpsSensor { get; set; }
    public required GyroscopeModel GyroscopeSensor { get; set; }
    public required TemperatureSensorModel EngineTemperatureSensor { get; set; }
    public required SpeedSensorModel SpeedSensor { get; set; }
}