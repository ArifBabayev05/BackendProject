using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class NewsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "CommentModels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Content1 = table.Column<string>(nullable: true),
                    BannerImage = table.Column<string>(nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    Title1 = table.Column<string>(nullable: true),
                    Text1 = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Text2 = table.Column<string>(nullable: true),
                    Title3 = table.Column<string>(nullable: true),
                    Text3 = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    Text4 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    Title4 = table.Column<string>(nullable: true),
                    AuthorDesc = table.Column<string>(nullable: true),
                    AuthorImage = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentModels_NewsId",
                table: "CommentModels",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentModels_News_NewsId",
                table: "CommentModels",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentModels_News_NewsId",
                table: "CommentModels");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropIndex(
                name: "IX_CommentModels_NewsId",
                table: "CommentModels");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "CommentModels");
        }
    }
}
