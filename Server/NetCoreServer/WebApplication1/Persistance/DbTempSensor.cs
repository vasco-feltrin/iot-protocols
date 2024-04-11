using System.ComponentModel.DataAnnotations;

namespace NetCoreServer.Persistance;

public class DbTempSensor
{
    [Key] [Required] public required Guid Id { get; set; }
    [Required] public required long Time { get; set; }
    [Required] public required double Celsius { get; set; }
}