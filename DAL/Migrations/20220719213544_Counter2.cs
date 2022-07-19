using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Counter2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Counters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Counters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Counters");
        }
    }
}
