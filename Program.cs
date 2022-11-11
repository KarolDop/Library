//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library
{

    public class Author
    {
        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public IList<Book> Books { get; set; }
    }

    public class Translator
    {
        public int Id { get; set; }
        public string TranslatorFirstName { get; set; }
        public string TranslatorLastName { get; set; }
        public IList<Book> Books { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public IList<Book> Books { get; set; }
    }

    public class Place
    {
        public int Id { get; set; }
        public string PublicationPlace { get; set; }
        public IList <Book> Books { get; set; }
    }

    public class Serie
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public IList<Book> Books { get; set; }
    }

    public class Remark
    {
        public int Id { get; set; }
        public string Remarks { get; set; }
        public Book Book { get; set; }
    }

    public enum HaveRead
    {
        No = 0,
        Yes = 1
    }

    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int PublishYear { get; set; }
        public IList<Author> Authors { get; set; }
        public IList<Translator> Translators { get; set; }
        public Publisher Publisher { get; set; }
        public Place Place { get; set; }
        public Serie Serie { get; set; }
        public IList<Remark> Remarks { get; set; }
        public HaveRead HaveReak { get; set; }
    }

    public class LibraryContex : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Remark> Remarks { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5JJ7LE4\SQLEXPRESS; Database=Library; Trusted_Connection=True");
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLibrary());
        }
    }
}