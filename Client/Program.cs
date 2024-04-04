using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

internal class Program
{
    private static void Main(string[] args)
    {
        // define sensors
        List<ISensor> sensors = new();
        sensors.Add(new VirtualSpeedSensor());
        sensors.Add(new VirtualGpsSensor());
        sensors.Add(new VirtualGyroscopeSensor());
        //sensors.Add(new VirtualEngineTemperatureSensor());
        // define protocol

        // send data to server

        foreach (ISensor sensor in sensors)
        {

            ConnectSensor(sensor);
        }
        Console.ReadKey();


    }
    public static async void ConnectSensor(ISensor sensor)
    {
        Task _ = new Task(() =>
        {
            while (true)
            {
                var sensorValue = sensor.ToJson();
                ProtocolInterface protocol = new Http(sensor.EndPoint, "http://192.168.101.178:5273/cars");

                protocol.Send(sensorValue);

                Console.WriteLine("Data sent: " + sensorValue);

                Thread.Sleep(1000);
            }
        });
        _.Start();
        await _;
    }
}