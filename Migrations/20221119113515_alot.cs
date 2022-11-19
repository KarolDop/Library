using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class alot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsbnNumber");

            migrationBuilder.DropTable(
                name: "TranslatorBook");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "Remarks",
                newName: "Remark");

            migrationBuilder.CreateTable(
                name: "IsbnNumbers",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsbnNumbers", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_IsbnNumbers_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatorsBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatorsBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatorsBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslatorsBook_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsbnNumbers_BookID",
                table: "IsbnNumbers",
                column: "BookID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatorsBook_BookId",
                table: "TranslatorsBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatorsBook_TranslatorId",
                table: "TranslatorsBook",
                column: "TranslatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsbnNumbers");

            migrationBuilder.DropTable(
                name: "TranslatorsBook");

            migrationBuilder.RenameColumn(
                name: "Remark",
                table: "Remarks",
                newName: "Remarks");

            migrationBuilder.CreateTable(
                name: "IsbnNumber",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsbnNumber", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_IsbnNumber_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatorBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatorBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatorBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslatorBook_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsbnNumber_BookID",
                table: "IsbnNumber",
                column: "BookID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatorBook_BookId",
                table: "TranslatorBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatorBook_TranslatorId",
                table: "TranslatorBook",
                column: "TranslatorId");
        }
    }
}
