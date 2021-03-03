using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ymltekstil.IdeaSoft.Server.Database;
using Ymltekstil.IdeaSoft.Server.Database.Entities;
using Ymltekstil.IdeaSoft.Server.Interfaces;

namespace Ymltekstil.IdeaSoft.Server.Services
{
    public class DbSettingsService : IDbSettingsService
    {
        AppDbContext _dbContext;

        public DbSettingsService()
        {
            _dbContext = new AppDbContext();
        }

        public string GetRefreshToken()
        {
            var settings = GetSettings();

            return settings.FirstOrDefault(x => x.Key == "RefreshToken").Value;
        }

        public IEnumerable<Settings> GetSettings()
        {
            return _dbContext.Settings;
        }


        public void UpdateRefreshToken(string newToken)
        {
            var setting = _dbContext.Settings.FirstOrDefault(x => x.Key == "RefreshToken");

            setting.Value = newToken;

            _dbContext.SaveChanges();
        }
    }
}
