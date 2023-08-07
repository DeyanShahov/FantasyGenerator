using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FantasyGenerator.Infrastructure.Data.Migrations
{
    public partial class ProfessionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Npcs");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Npcs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfessionId",
                table: "Npcs",
                type: "uniqueidentifier",
                maxLength: 68,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 68, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professions_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Npcs_ProfessionId",
                table: "Npcs",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_AuthorId",
                table: "Professions",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Npcs_Professions_ProfessionId",
                table: "Npcs",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Npcs_Professions_ProfessionId",
                table: "Npcs");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_Npcs_ProfessionId",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Npcs");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Npcs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Npcs",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }
    }
}
