using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class AddingNpcName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NpcsName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    IsFirstName = table.Column<bool>(type: "bit", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SuitableRace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcsName", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NpcsName");
        }
    }
}
