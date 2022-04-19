using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Data.Migrations
{
    public partial class Npc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Npcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NickNamePrefix = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NickNameSuffix = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Npcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Npcs_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Npcs_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Npcs_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Npcs_AuthorId",
                table: "Npcs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Npcs_ProfessionId",
                table: "Npcs",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Npcs_RaceId",
                table: "Npcs",
                column: "RaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Npcs");
        }
    }
}
