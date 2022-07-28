using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class NewsMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastContext",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastContext",
                table: "News");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "News");
        }
    }
}
