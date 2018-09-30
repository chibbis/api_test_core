using RestSharp;

namespace RestApiCore
{
    public static class PostRequest
    {
        public static RestRequest CreatePostRequest(this RestClient client, string route, object body)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = route;
            request.AddJsonBody(body);
            return request;
        }

        /*public static IRestResponse Send(this RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            return response;
        }*/
    }
}
