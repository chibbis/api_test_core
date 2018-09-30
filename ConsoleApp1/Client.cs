using RestApiCore;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace RestApiName
{
    abstract public class Client : IClient
    {
        private RestClient client;
        private RestRequest request;
        readonly string BaseUrl;

        abstract public RestClient CreateClient();

        /*public RestRequest CreateRequest(string route)
        {
            RestRequest request = new RestRequest();
            request.Resource = route;
            return request;
        }

        public IRestResponse SendRequest()
        {
            IRestResponse response = client.Execute(request);
            return response;
        }*/
    }
}
