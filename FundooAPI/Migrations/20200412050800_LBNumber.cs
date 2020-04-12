using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooAPI.Migrations
{
    public partial class LBNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LBNumber",
                table: "Labels",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LBNumber",
                table: "Labels");
        }
    }
}
