using System.Text;

namespace NetCoreClient.Protocols;

class Http : IProtocolInterface
{
    private readonly string _endpoint;
    private readonly string _url;
    //private HttpWebRequest httpWebRequest;

    public Http(string endpoint,string url)
    {
        _endpoint = endpoint;
        _url = url;
    }

    public async void Send(string data)
    {
        var client = new HttpClient();
        //client.BaseAddress = new Uri(Url);

        var endpointUrl = new Uri(_url) + _endpoint;

        var result = await client.PostAsync(endpointUrl, new StringContent(data,Encoding.UTF8,"application/json"));

        Console.Out.WriteLine(result.StatusCode);
    }
}