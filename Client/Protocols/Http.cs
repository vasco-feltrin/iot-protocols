using System.Net;

namespace NetCoreClient.Protocols
{
    class Http : ProtocolInterface
    {
        private string Endpoint;
        private string Url;
        //private HttpWebRequest httpWebRequest;

        public Http(string endpoint,string Url)
        {
            this.Endpoint = endpoint;
            this.Url = Url;
        }

        public async void Send(string data)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Url);

            var result = await client.PostAsync(Endpoint, new StringContent(data));

            Console.Out.WriteLine(result.StatusCode);
        }
    }
}
