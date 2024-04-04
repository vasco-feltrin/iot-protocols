using System.Net;
using System.Text;

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

            //var endpointUrl = new Uri(Url) + Endpoint;

            var result = await client.PostAsync(Endpoint, new StringContent(data,Encoding.UTF8,"application/json"));

            Console.Out.WriteLine(result.StatusCode);
        }
    }
}
