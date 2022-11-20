using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class AddViewAllBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" CREATE VIEW View_AllBooks AS
                                SELECT authors.FullName as Autor, translators.FullName AS Tłumacz, books.BookName AS Tytuł, series.SeriesName AS Seria,
                                publishers.PublisherName AS Wydawnictwo, books.PublishYear AS 'Rok wydania', books.HaveRead AS Przeczytane
                                FROM Library.dbo.Books books
                                LEFT JOIN Library.dbo.AuthorBook ab on ab.BookId = books.Id
                                LEFT JOIN Library.dbo.Authors authors on authors.Id = ab.AuthorId
                                LEFT JOIN Library.dbo.TranslatorsBook tb on tb.BookId = books.Id
                                LEFT JOIN Library.dbo.Translators translators on translators.Id = tb.TranslatorId
                                LEFT JOIN Library.dbo.SerieBooks sb on sb.BookId = books.Id
                                LEFT JOIN Library.dbo.Series series on series.Id = sb.SerieId
                                LEFT JOIN Library.dbo.Publishers publishers on publishers.Id = books.PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" DROP VIEW View_AllBooks");
        }
    }
}
