namespace Models;

public class GpsSensorModel
{
    public required long Time { get; set; }
    public required double Latitude { get; set; }
    public required double Longitude { get; set; }
    public required double Altitude { get; set; }
}