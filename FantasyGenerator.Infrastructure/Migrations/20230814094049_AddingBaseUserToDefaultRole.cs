using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class AddingBaseUserToDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "150fb092-25dd-42fa-8e64-d461cfbc95c1", "0bb5d373-977e-46ae-9763-efe5a6ed1ecb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "150fb092-25dd-42fa-8e64-d461cfbc95c1", "0bb5d373-977e-46ae-9763-efe5a6ed1ecb" });
        }
    }
}
