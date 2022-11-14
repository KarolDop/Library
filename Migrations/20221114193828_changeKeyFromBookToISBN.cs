using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class changeKeyFromBookToISBN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_IsbnNumber_IsbnID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_IsbnID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsbnID",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "IsbnNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IsbnNumber_BookID",
                table: "IsbnNumber",
                column: "BookID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IsbnNumber_Books_BookID",
                table: "IsbnNumber",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IsbnNumber_Books_BookID",
                table: "IsbnNumber");

            migrationBuilder.DropIndex(
                name: "IX_IsbnNumber_BookID",
                table: "IsbnNumber");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "IsbnNumber");

            migrationBuilder.AddColumn<string>(
                name: "IsbnID",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Books_IsbnID",
                table: "Books",
                column: "IsbnID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_IsbnNumber_IsbnID",
                table: "Books",
                column: "IsbnID",
                principalTable: "IsbnNumber",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
