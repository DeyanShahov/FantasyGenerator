using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class AddingDefaultUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "150fb092-25dd-42fa-8e64-d461cfbc95c1", "5f6a48ef-0337-4981-ba78-7f6a9afb08b7", "DefaultUser", "DEFAULTUSER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "150fb092-25dd-42fa-8e64-d461cfbc95c1");
        }
    }
}
