namespace Models;

public class GyroscopeModel
{
    public long Time { get; set; }

    public required double XAxis { get; set; }
    public required double YAxis { get; set;}
    public required double ZAxis { get; set;}
}