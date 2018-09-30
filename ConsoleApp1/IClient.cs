using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiCore
{
    public interface IClient
    {
        RestClient CreateClient();
        /*RestRequest CreateRequest(string route);
        IRestResponse SendRequest();*/
    }
}

