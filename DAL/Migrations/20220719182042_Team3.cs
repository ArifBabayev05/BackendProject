using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Team3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceYear",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text1",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text3",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceYear",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Text1",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Text3",
                table: "Teams");
        }
    }
}
