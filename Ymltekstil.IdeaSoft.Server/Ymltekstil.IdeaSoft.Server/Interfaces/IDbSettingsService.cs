using System.Collections.Generic;
using Ymltekstil.IdeaSoft.Server.Database.Entities;

namespace Ymltekstil.IdeaSoft.Server.Interfaces
{
    public interface IDbSettingsService
    {
        IEnumerable<Settings> GetSettings();

        void UpdateRefreshToken(string newToken);
        string GetRefreshToken();
    }
}
