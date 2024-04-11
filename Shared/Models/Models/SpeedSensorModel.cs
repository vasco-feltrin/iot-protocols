namespace Models
{
    public class SpeedSensorModel
    {
        public required Guid Id { get; set; }

        public required long Time { get; set; }

        public required double KilometersPerHour { get; set; }
    }
}
