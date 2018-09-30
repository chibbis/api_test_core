using ApiFacade.Models.RequestModels;
using RestApiCore;

namespace TestApiFacade
{
    public class GetGuestToken
    {
        IClient Client;

        public void GetToken(GetGuestTokenRequestModel data)
        {
            Client.CreateClient().CreatePostRequest("/api/v2/auth/get_guest_token", data).Execute();
        }
    }
}
