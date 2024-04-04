﻿using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensor> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualGpsSensor());
sensors.Add(new VirtualGyroscopeSensor());
sensors.Add(new VirtualGyroscopeSensor());
// define protocol

// send data to server

foreach (ISensor sensor in sensors)
{

    Task _ = new Task(() =>
    {
        while (true)
        {
            var sensorValue = sensor.ToJson();
            ProtocolInterface protocol = new Http(sensor.EndPoint, "http://localhost:8011/cars/123");

            protocol.Send(sensorValue);

            Console.WriteLine("Data sent: " + sensorValue);

            Thread.Sleep(1000);
        }
    });
}