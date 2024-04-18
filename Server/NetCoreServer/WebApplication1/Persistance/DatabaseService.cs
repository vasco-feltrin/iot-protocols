using Models;

namespace NetCoreServer.Persistance;

public class DatabaseService
{
    private readonly CarDatabaseContext _context;
    public DatabaseService()
    {
        _context = new CarDatabaseContext();
        _context.Database.EnsureCreated();
    }

    public void AddSpeedMeasurement(SpeedSensorModel model)
    {
        _context.Speed.Add(new DbSpeedSensor
        {
            Id = model.Id,
            Time = model.Time,
            KilometersPerHour = model.KilometersPerHour
        });
    }

    public void AddTemperatureMeasurement(TemperatureSensorModel model)
    {
        _context.Temperature.Add(new DbTempSensor
        {
            Id = model.Id,
            Time = model.Time,
            Celsius = model.Celsius
        });
    }

    public void AddGyroMeasurement(GyroscopeModel model)
    {
        _context.Gyro.Add(new DbGyroSensor
        {
            Id = model.Id,
            Time = model.Time,
            XAxis = model.XAxis,
            YAxis = model.YAxis,
            ZAxis = model.ZAxis
        });
    }

    public void AddGpsMeasurement(GpsSensorModel model)
    {
        _context.Gps.Add(new DbGpsSensor
        {
            Id = model.Id,
            Time = model.Time,
            Latitude = model.Latitude,
            Longitude = model.Longitude,
            Altitude = model.Altitude
        });
    }
}