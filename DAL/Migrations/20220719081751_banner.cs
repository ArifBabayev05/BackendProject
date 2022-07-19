using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class banner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExampleImage3",
                table: "MainFocuses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExampleImage3",
                table: "MainFocuses");
        }
    }
}
