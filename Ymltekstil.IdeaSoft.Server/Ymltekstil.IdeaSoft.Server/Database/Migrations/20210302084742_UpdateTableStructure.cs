using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymltekstil.IdeaSoft.Server.Database.Migrations
{
    public partial class UpdateTableStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("bfd6baa2-5ba7-4268-a132-4c0dd0c8b985"));

            migrationBuilder.RenameColumn(
                name: "RefreshToken",
                table: "Settings",
                newName: "Value");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Settings",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { new Guid("fefd4aa6-cf58-43ba-b69c-1ed2ca9aa101"), "RefreshToken", "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("fefd4aa6-cf58-43ba-b69c-1ed2ca9aa101"));

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Settings",
                newName: "RefreshToken");

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "RefreshToken" },
                values: new object[] { new Guid("bfd6baa2-5ba7-4268-a132-4c0dd0c8b985"), "MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA" });
        }
    }
}
