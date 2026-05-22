using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPCOREWEB.Migrations
{
    /// <inheritdoc />
    public partial class tablename_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "BooksTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksTable",
                table: "BooksTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksTable",
                table: "BooksTable");

            migrationBuilder.RenameTable(
                name: "BooksTable",
                newName: "books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }
    }
}
