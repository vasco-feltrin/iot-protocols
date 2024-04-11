using System.ComponentModel.DataAnnotations;

namespace NetCoreServer.Persistance;

public class DbGpsSensor
{
    [Key] [Required] public Guid Id { get; set; }

    [Required] public long Time { get; set; }
    [Required] public double Latitude { get; set; }
    [Required] public double Longitude { get; set; }
    [Required] public double Altitude { get; set; }
}