using RabbitMQ.Client;

namespace NetCoreClient.Protocols;

public class AmqpProtocolInterface : IProtocolInterface
{
    public void Send(string data)

    {
        // send data here
        // Define connection factory
        ConnectionFactory factory = new()
        {
            HostName = "localhost", // RabbitMQ server host
            Port = 5672,            // RabbitMQ server port
            UserName = "guest",     // RabbitMQ username
            Password = "guest"      // RabbitMQ password
        };

        // Create connection
        using (var connection = factory.CreateConnection())
        {
            // Create channel
            using (var channel = connection.CreateModel())
            {
                // Use the channel for further operations, like creating queues, exchanges, publishing messages, etc.
                Console.WriteLine("Connected to RabbitMQ!");
            }
        }
    }
}