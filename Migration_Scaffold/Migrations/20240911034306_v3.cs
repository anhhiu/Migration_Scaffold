using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_Scaffold.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_articleTags_ArticleId",
                table: "articleTags");

            migrationBuilder.DropColumn(
                name: "ArticleIdnew",
                table: "articleTags");

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_ArticleId_TagId",
                table: "articleTags",
                columns: new[] { "ArticleId", "TagId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_articleTags_ArticleId_TagId",
                table: "articleTags");

            migrationBuilder.AddColumn<int>(
                name: "ArticleIdnew",
                table: "articleTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_ArticleId",
                table: "articleTags",
                column: "ArticleId");
        }
    }
}
