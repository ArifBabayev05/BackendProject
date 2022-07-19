using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MainFocusFi2x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "MainFocuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExampleImage1",
                table: "MainFocuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExampleImage2",
                table: "MainFocuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherDescription",
                table: "MainFocuses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "MainFocuses");

            migrationBuilder.DropColumn(
                name: "ExampleImage1",
                table: "MainFocuses");

            migrationBuilder.DropColumn(
                name: "ExampleImage2",
                table: "MainFocuses");

            migrationBuilder.DropColumn(
                name: "OtherDescription",
                table: "MainFocuses");
        }
    }
}
