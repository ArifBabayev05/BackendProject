using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class FeatureMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Features");

            migrationBuilder.AddColumn<int>(
                name: "BathCount",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BedCount",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuildYear",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Features",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Features",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSale",
                table: "Features",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MainPhoto",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherImage1",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherImage2",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalesManName",
                table: "Features",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRoomCount",
                table: "Features",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BathCount",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "BedCount",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "BuildYear",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "IsSale",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "MainPhoto",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "OtherImage1",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "OtherImage2",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SalesManName",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "TotalRoomCount",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Features",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
