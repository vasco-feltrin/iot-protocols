using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensor> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualGpsSensor());
sensors.Add(new VirtualGpsSensor());
// define protocol
ProtocolInterface protocol = new Http("http://localhost:8011/cars/123");

// send data to server

foreach (ISensor sensor in sensors)
{

    Task _ = new Task(() =>
    {
        while (true)
        {
            var sensorValue = sensor.ToJson();

            protocol.Send(sensorValue);

            Console.WriteLine("Data sent: " + sensorValue);

            Thread.Sleep(1000);
        }
    });
}