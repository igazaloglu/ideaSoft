using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymltekstil.IdeaSoft.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { new Guid("44783db6-948d-422d-84fc-2af908e4cc0a"), "RefreshToken", "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
