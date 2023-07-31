using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOKWEB.Migrations
{
    /// <inheritdoc />
    public partial class AddClassBookweb_31_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublic = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryBooks",
                columns: table => new
                {
                    CategoryBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBooks", x => x.CategoryBookId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRoles",
                columns: table => new
                {
                    CategoryRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRoles", x => x.CategoryRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BookCategoryBook",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    CategoryBooksCategoryBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategoryBook", x => new { x.BooksBookId, x.CategoryBooksCategoryBookId });
                    table.ForeignKey(
                        name: "FK_BookCategoryBook_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategoryBook_CategoryBooks_CategoryBooksCategoryBookId",
                        column: x => x.CategoryBooksCategoryBookId,
                        principalTable: "CategoryBooks",
                        principalColumn: "CategoryBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usernames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_CategoryRoles_CategoryRoleId",
                        column: x => x.CategoryRoleId,
                        principalTable: "CategoryRoles",
                        principalColumn: "CategoryRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    RepositoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepositoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.RepositoryID);
                    table.ForeignKey(
                        name: "FK_Repositories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRepository",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    RepositoriesRepositoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRepository", x => new { x.BooksBookId, x.RepositoriesRepositoryID });
                    table.ForeignKey(
                        name: "FK_BookRepository_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRepository_Repositories_RepositoriesRepositoryID",
                        column: x => x.RepositoriesRepositoryID,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CategoryRoleId",
                table: "Accounts",
                column: "CategoryRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategoryBook_CategoryBooksCategoryBookId",
                table: "BookCategoryBook",
                column: "CategoryBooksCategoryBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRepository_RepositoriesRepositoryID",
                table: "BookRepository",
                column: "RepositoriesRepositoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_UserId",
                table: "Repositories",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "BookCategoryBook");

            migrationBuilder.DropTable(
                name: "BookRepository");

            migrationBuilder.DropTable(
                name: "CategoryRoles");

            migrationBuilder.DropTable(
                name: "CategoryBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
