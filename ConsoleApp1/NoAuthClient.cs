using RestApiName;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace RestApiCore
{
    public class NoAuthClient: Client
    {
        private RestClient client;
        readonly string BaseUrl;


        override public RestClient CreateClient()
        {
            client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            return client;
        }
    }
}
