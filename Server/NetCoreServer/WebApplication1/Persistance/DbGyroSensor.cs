using System.ComponentModel.DataAnnotations;

namespace NetCoreServer.Persistance;

public class DbGyroSensor
{
    [Key][Required] public required Guid Id { get; set; }

    [Required] public required long Time { get; set; }

    [Required] public required double XAxis { get; set; }

    [Required] public required double YAxis { get; set; }

    [Required] public required double ZAxis { get; set; }
}