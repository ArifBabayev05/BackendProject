using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class fixing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorDesc",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorImage",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage1",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage2",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage3",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImage4",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "CommentModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommentModels_PropertyId",
                table: "CommentModels",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentModels_Properties_PropertyId",
                table: "CommentModels",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentModels_Properties_PropertyId",
                table: "CommentModels");

            migrationBuilder.DropIndex(
                name: "IX_CommentModels_PropertyId",
                table: "CommentModels");

            migrationBuilder.DropColumn(
                name: "AuthorDesc",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "AuthorImage",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SliderImage1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SliderImage2",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SliderImage3",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SliderImage4",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "CommentModels");
        }
    }
}
