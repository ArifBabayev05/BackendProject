using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class CommentMigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentModels",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUser = table.Column<string>(nullable: true),
                    CommentContent = table.Column<string>(nullable: true),
                    CommentState = table.Column<bool>(nullable: false),
                    Feature2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentModels", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_CommentModels_Features_Feature2Id",
                        column: x => x.Feature2Id,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentModels_Feature2Id",
                table: "CommentModels",
                column: "Feature2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentModels");
        }
    }
}
