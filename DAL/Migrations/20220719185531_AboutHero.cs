using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AboutHero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Add2",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Add3",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Add4",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Add2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Add3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Add4",
                table: "Abouts");
        }
    }
}
