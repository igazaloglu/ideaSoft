using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models
{
    public class IdeaSoftTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
