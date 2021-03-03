using System;
using Microsoft.EntityFrameworkCore;
using Ymltekstil.IdeaSoft.Server.Database.Entities;

namespace Ymltekstil.IdeaSoft.Server.Database
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"DataSource=ymlDb.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string refreshToken = "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA";
            modelBuilder.Entity<Settings>().HasData(new Settings { Key = "RefreshToken", Value = refreshToken, Id = Guid.NewGuid()});
            }

        public DbSet<Settings> Settings { get; set; }

    }
}
