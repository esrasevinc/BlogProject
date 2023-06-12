using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsraSevincBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeEklemeleriYapıldı : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateTime",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteTime",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateTime",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogAuthor",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogSummary",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateTime",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteTime",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateTime",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "BlogAuthor",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "BlogSummary",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Blog");
        }
    }
}
