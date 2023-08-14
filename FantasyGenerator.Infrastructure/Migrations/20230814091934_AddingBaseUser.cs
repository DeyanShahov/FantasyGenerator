using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class AddingBaseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0bb5d373-977e-46ae-9763-efe5a6ed1ecb", 0, "fd3af8c1-8f16-478a-9315-b4fc59dd563f", "baseuser@baseuser.com", true, true, null, "BASEUSER@BASEUSER.COM", "BASEUSER", "AQAAAAEAACcQAAAAEKTaDGVGMc4iTM0t93yYVAaQPJyV/157OuV3+Pf2AJCodBSQl9+zLTdK76fKVlT9WQ==", null, false, null, false, "BaseUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb5d373-977e-46ae-9763-efe5a6ed1ecb");
        }
    }
}
