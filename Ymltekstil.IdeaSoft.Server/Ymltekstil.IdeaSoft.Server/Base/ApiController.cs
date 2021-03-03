using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ymltekstil.IdeaSoft.Server.Interfaces;

namespace Ymltekstil.IdeaSoft.Server.Base
{
    public abstract class ApiController : ControllerBase
    {
        protected IIdeaSoftClient IdeaSoftClient;

        protected IDbSettingsService DbSettingsService;

        protected ApiController(IDbSettingsService dbSettingsService, IIdeaSoftClient ideaSoftClient)
        {
            DbSettingsService = dbSettingsService;
            IdeaSoftClient = ideaSoftClient;
        }

        public virtual bool AuthorizeWithHeader()
        {
            HttpContext.Request.Headers.TryGetValue("access_token", out var token);

            if (string.IsNullOrEmpty(token))
            {
                return false;
            }

            IdeaSoftClient.Authorize(token);

            return true;
        }

        public async virtual Task Authorize()
        {
            var refreshToken = DbSettingsService.GetRefreshToken();

            var tokenResponse = await IdeaSoftClient.GetToken(refreshToken);

            DbSettingsService.UpdateRefreshToken(tokenResponse.RefreshToken);

            IdeaSoftClient.Authorize(tokenResponse.AccessToken);
        }
    }
}
