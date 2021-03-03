using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymltekstil.IdeaSoft.Server.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RefreshToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "RefreshToken" },
                values: new object[] { new Guid("bfd6baa2-5ba7-4268-a132-4c0dd0c8b985"), "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
