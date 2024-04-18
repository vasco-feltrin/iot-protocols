using MQTTnet;
using MQTTnet.Client;


using MQTTnet.Extensions.ManagedClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.Protocols
{
    public class Mqtt : ProtocolInterface
    {
        private string Endpoint;
        private string Topic;
        //private HttpWebRequest httpWebRequest;

        public Mqtt(string endpoint, string Topic)
        {
            this.Endpoint = endpoint;
            this.Topic = Topic;
        }
        public async void Send(string data)
        {
            var options = new MqttClientOptionsBuilder()
             .WithTcpServer(Conf.BrokerMqttUrl, 1883) // Imposta l'indirizzo e la porta del broker MQTT.
             .WithClientId(Guid.NewGuid().ToString()) // Imposta l'ID del client.
             .Build();

            var factory = new MqttFactory();
            var client = factory.CreateMqttClient();

            // Gestione degli eventi di connessione.
            
                //Console.WriteLine("Client connesso al broker MQTT.");
            await client.ConnectAsync(options);

            // Definizione del messaggio da pubblicare.
            var message = new MqttApplicationMessageBuilder()
                    .WithTopic(Topic+Endpoint) // Specifica il topic del messaggio.
                    .WithPayload(data) // Specifica il contenuto del messaggio.
                    .WithQualityOfServiceLevel(0) // Imposta la QoS del messaggio.
                    .WithRetainFlag() // Imposta il flag di retain.
                    .Build();

                // Pubblicazione del messaggio.
              await  client.PublishAsync(message);

                
            

            // Connessione al broker MQTT.

            // Attesa della conferma di connessione.
            

            // Disconnessione dal broker MQTT.
           await client.DisconnectAsync();
        }
    }
}