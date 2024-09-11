using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_Scaffold.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleTagIdId",
                table: "articleTags",
                newName: "ArticleTagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleTagId",
                table: "articleTags",
                newName: "ArticleTagIdId");
        }
    }
}
