using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooAPI.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "LBNumber",
                table: "Labels");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Labels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Labels");

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Notes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LBNumber",
                table: "Labels",
                nullable: false,
                defaultValue: 0);
        }
    }
}
