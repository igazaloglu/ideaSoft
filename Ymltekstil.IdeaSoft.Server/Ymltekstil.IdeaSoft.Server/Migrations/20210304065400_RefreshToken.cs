using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ymltekstil.IdeaSoft.Server.Migrations
{
    public partial class RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Settings SET Value = 'YTMzNzg5NDllOTE2MjUzMmJlMWQyZjQwZDM4NDhkMDM1NDI5ODk1MGFiYmM5YzYzMzNkMzMyYzYwZTY4OWQ0Mg' WHERE \"Key\" = 'RefreshToken'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
                  }
    }
}
