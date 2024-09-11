using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_Scaffold.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_articleTags",
                table: "articleTags");

            migrationBuilder.DropIndex(
                name: "IX_articleTags_ArticleId_TagId",
                table: "articleTags");

            migrationBuilder.AddColumn<int>(
                name: "ArticleTagIdId",
                table: "articleTags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ArticleIdnew",
                table: "articleTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_articleTags",
                table: "articleTags",
                column: "ArticleTagIdId");

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_ArticleId",
                table: "articleTags",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_articleTags",
                table: "articleTags");

            migrationBuilder.DropIndex(
                name: "IX_articleTags_ArticleId",
                table: "articleTags");

            migrationBuilder.DropColumn(
                name: "ArticleTagIdId",
                table: "articleTags");

            migrationBuilder.DropColumn(
                name: "ArticleIdnew",
                table: "articleTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_articleTags",
                table: "articleTags",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_ArticleId_TagId",
                table: "articleTags",
                columns: new[] { "ArticleId", "TagId" },
                unique: true);
        }
    }
}
