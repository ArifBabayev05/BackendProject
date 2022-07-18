using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorDesc",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorImage",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFloorDesc",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFloorImage",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthFloorDesc",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthFloorImage",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllowedForPets",
                table: "Features",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LoungeArea",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OtherImage3",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherImage4",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecondFloorDesc",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFloorImage",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage1",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage2",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage3",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage4",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFloorDesc",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFloorImage",
                table: "Features",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorDesc",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "AuthorImage",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FirstFloorDesc",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FirstFloorImage",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FourthFloorDesc",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FourthFloorImage",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IsAllowedForPets",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "LoungeArea",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "OtherImage3",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "OtherImage4",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SecondFloorDesc",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SecondFloorImage",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SliderImage1",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SliderImage2",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SliderImage3",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SliderImage4",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ThirdFloorDesc",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ThirdFloorImage",
                table: "Features");
        }
    }
}
