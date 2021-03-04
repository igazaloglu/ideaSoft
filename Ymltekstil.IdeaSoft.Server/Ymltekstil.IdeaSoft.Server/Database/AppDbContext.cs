using System;
using Microsoft.EntityFrameworkCore;
using Ymltekstil.IdeaSoft.Server.Database.Entities;

namespace Ymltekstil.IdeaSoft.Server.Database
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=yml;Integrated Security=True");
        }
        public DbSet<Settings> Settings { get; set; }

    }
}
