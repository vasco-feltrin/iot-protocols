using NetCoreClient.Sensors;
using NetCoreClient.Protocols;
using Microsoft.Extensions.Configuration;
using NetCoreClient;



// Access settings


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
            ProtocolInterface protocol = new Http(sensor.EndPoint, $" http://localhost:5273/cars/{Conf.CarId}");
        
            //protocol.Send(sensorValue);
            protocol = new Mqtt(sensor.EndPoint, $"cars/{Conf.CarId}");
            protocol.Send(sensorValue);
            Console.WriteLine("Data sent: " + sensorValue);

            Thread.Sleep(1000);
        }
    });
    _.Start();
}
Console.ReadKey();
