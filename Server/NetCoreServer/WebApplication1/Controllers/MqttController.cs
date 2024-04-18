using System.Text;
using System.Text.Json;
using Models;
using MQTTnet;
using MQTTnet.Client;
using NetCoreClient;

public class MqttController : IHostedService
{
    private readonly IMqttClient _client;

    public MqttController()
    {
        MqttFactory factory = new();
        _client = factory.CreateMqttClient();
    }

    private Task OnClientConnectedAsync(MqttClientConnectedEventArgs args)
    {
        Console.WriteLine("Client is connected");
        return Task.CompletedTask;
    }
    


    //public async Task Initialize()
    //{


    //    // Gestione degli eventi di connessione.

    //    //Console.WriteLine("Client connesso al broker MQTT.");


    //    //// Definizione del messaggio da pubblicare.
    //    //var message = new MqttApplicationMessageBuilder()
    //    //    .WithTopic(topic + endpoint) // Specifica il topic del messaggio.
    //    //    .WithPayload(data) // Specifica il contenuto del messaggio.
    //    //    .WithQualityOfServiceLevel(0) // Imposta la QoS del messaggio.
    //    //    .WithRetainFlag() // Imposta il flag di retain.
    //    //    .Build();

    //    // Pubblicazione del messaggio.
    //    //await client.PublishAsync(message);


    //    //// Connessione al broker MQTT.

    //    //// Attesa della conferma di connessione.


    //    //// Disconnessione dal broker MQTT.
    //    //await client.DisconnectAsync();
    //}
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        MqttClientOptions? options = new MqttClientOptionsBuilder()
            .WithTcpServer(Conf.BrokerMqttUrl, 1883) // Imposta l'indirizzo e la porta del broker MQTT.
            .WithClientId(Guid.NewGuid().ToString()) // Imposta l'ID del client.
            .Build();

        var topicFilter = new MqttTopicFilterBuilder().WithTopic("cars/a233cbe4-8fc4-4eb2-9d7b-02705a4f0716/#");

        MqttClientSubscribeOptions opts = new MqttClientSubscribeOptionsBuilder()
            .WithTopicFilter(topicFilter)
            .Build();

        _client.ConnectedAsync += OnClientConnectedAsync;
        _client.ApplicationMessageReceivedAsync += OnMessageReceivedAsync;
        await _client.ConnectAsync(options);
        await _client.SubscribeAsync(opts);
        Console.WriteLine("Client initialized");
    }

    private Task OnMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs args)
    {
        var sender = args.ClientId;
        var payload = args.ApplicationMessage.PayloadSegment.ToArray();
        var message = Encoding.UTF8.GetString(payload);
        Console.WriteLine($"{sender}: {message}");

        CarModel model;
        try
        {
            model = JsonSerializer.Deserialize<CarModel>(message) ?? throw new Exception();
            
        }
        catch
        {

        }
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}