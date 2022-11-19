using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class deletedPlaceAsTableAddAsFieldToBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Places_PlaceId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Books_PlaceId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "HaveReak",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Books",
                newName: "HaveRead");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "HaveRead",
                table: "Books",
                newName: "PlaceId");

            migrationBuilder.AddColumn<int>(
                name: "HaveReak",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PlaceId",
                table: "Books",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Places_PlaceId",
                table: "Books",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
