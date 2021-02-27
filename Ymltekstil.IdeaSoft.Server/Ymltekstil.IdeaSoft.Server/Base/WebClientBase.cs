using RestSharp;

namespace Ymltekstil.IdeaSoft.Server.Base
{
    public abstract class WebClientBase
    {
        protected IRestClient RestClient;

        public WebClientBase(string baseUrl)
        {
            RestClient = new RestClient(baseUrl);
        }

        public virtual void Authorize(string bearerToken)
        {
            RestClient.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
        }
    }
}
