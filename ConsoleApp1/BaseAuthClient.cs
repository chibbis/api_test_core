using RestApiName;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace RestApiCore
{
    public class BaseAuthClient: Client
    {
        private RestClient client;
        readonly string BaseUrl;

        public HttpBasicAuthenticator BaseAuth()
        {
            return new HttpBasicAuthenticator("username", "password");
        }

        override public RestClient CreateClient()
        {
            client = new RestClient
            {
                BaseUrl = new Uri(BaseUrl),
                Authenticator = BaseAuth()
            };
            return client;
        }
    }
}
