﻿using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualGpsSensor())
// define protocol
ProtocolInterface protocol = new Http("http://localhost:8011/cars/123");

// send data to server
while (true)
{
    foreach (ISensorInterface sensor in sensors)
    {



        var sensorValue = sensor.ToJson();

        protocol.Send(sensorValue);

        Console.WriteLine("Data sent: " + sensorValue);

        Thread.Sleep(1000);
    }

}