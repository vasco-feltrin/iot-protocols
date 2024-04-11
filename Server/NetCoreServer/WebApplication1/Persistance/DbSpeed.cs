using System.ComponentModel.DataAnnotations;

namespace NetCoreServer.Persistance;

public class DbSpeedSensor
{
    ///// <summary>
    /////     Timestamp in long (millisecondi dal 1970) UNIX TIME (Epoch Time)
    ///// </summary>
    //[Key] 
    //internal long TimeStamp { get; init; }

    ///// <summary>
    /////     La temperatura registrata in Celsius
    ///// </summary>
    //[Required]
    //[Range(10f, 45f)]
    //internal float CelsiusDegrees { get; init; }

    [Key]
    public Guid Id { get; set; }

    [Required]
    public long Time { get; set; }

    [Required]
    public double KilometersPerHour { get; set; }
}