using NetCoreClient.Sensors;
using NetCoreClient.Protocols;
using NetCoreClient;


// Access settings
VirtualCar car = new VirtualCar();

// define sensors
//List<ISensor> sensors = new();
//sensors.Add(new VirtualSpeedSensor());
//sensors.Add(new VirtualGpsSensor());
//sensors.Add(new VirtualGyroscopeSensor());
//sensors.Add(new VirtualEngineTemperatureSensor());
// define protocol

// send data to server

//foreach (ISensor sensor in sensors)
//{

    Task _ = new(() =>
    {
        while (true)
        {
            var sensorValue = car.ToJson();
            IProtocolInterface protocol = new Http(car.EndPoint, $" http://localhost:5273/cars/{Conf.CarId}");
        
            //protocol.Send(sensorValue);
            protocol = new Mqtt(car.EndPoint, $"cars/");
            protocol.Send(sensorValue);
            Console.WriteLine("Data sent: " + sensorValue);

            Thread.Sleep(1000);
        }
    });
    _.Start();
//}
Console.ReadKey();
