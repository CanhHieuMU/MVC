using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOKWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddPDFBook_23_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PDFUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PDFUrl",
                table: "Books");
        }
    }
}
