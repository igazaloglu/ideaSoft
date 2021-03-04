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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string refreshToken = "NzdiZDlmYzNhYzc2ZGU0ZDA1YzQ1YjRlNjAzNDRlOTI3OTNhZjViODY3ZGZkYTFhZDFlOGQ1NzJmMmE5NmY5Yw";

            modelBuilder.Entity<Settings>().HasData(new Settings { Key = "RefreshToken", Value = refreshToken, Id = Guid.NewGuid() });
        }

        public DbSet<Settings> Settings { get; set; }

    }
}
