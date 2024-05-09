namespace NetCoreClient.Protocols;

/// <summary>
///     Definisce un'interfaccia per interfacciarsi con un'interfaccia
/// </summary>
public interface IProtocolInterface
{
    public void Send(string data);
}