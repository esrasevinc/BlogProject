using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsraSevincBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class CategoryIDEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Blog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryID",
                table: "Blog",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Category_CategoryID",
                table: "Blog",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Category_CategoryID",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_CategoryID",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Blog");
        }
    }
}
