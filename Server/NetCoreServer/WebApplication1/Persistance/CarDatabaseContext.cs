using Microsoft.EntityFrameworkCore;

namespace NetCoreServer.Persistance;

public class CarDatabaseContext : DbContext
{
    public DbSet<DbSpeedSensor> Speed { get; set; }
    public DbSet<DbGyroSensor> Gyro { get; set; }
    public DbSet<DbTempSensor> Temperature { get; set; }
    public DbSet<DbGpsSensor> Gps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //throw new NotImplementedException();
        options.UseSqlite("Data Source=mydatabase.db");
    }
}