using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class fixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExampleImage1",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExampleImage2",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExampleImage3",
                table: "Properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ExampleImage1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ExampleImage2",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ExampleImage3",
                table: "Properties");
        }
    }
}
