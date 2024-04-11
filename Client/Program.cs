using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

Guid id = Guid.Parse("A233CBE4-8FC4-4EB2-9D7B-02705A4F0716");
// define sensors
List<ISensor> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualGpsSensor());
sensors.Add(new VirtualGyroscopeSensor());
sensors.Add(new VirtualEngineTemperatureSensor());
// define protocol

// send data to server

foreach (ISensor sensor in sensors)
{

    Task _ = new Task(() =>
    {
        while (true)
        {
            var sensorValue = sensor.ToJson();
            ProtocolInterface protocol = new Http(sensor.EndPoint, $" http://localhost:5273/cars/{id}");

            protocol.Send(sensorValue);

            Console.WriteLine("Data sent: " + sensorValue);

            Thread.Sleep(1000);
        }
    });
    _.Start();
}
Console.ReadKey();
