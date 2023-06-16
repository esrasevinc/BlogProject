using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsraSevincBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class BlogTablosunaCategoryNameEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Blog");
        }
    }
}
