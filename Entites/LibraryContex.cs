﻿using Library.Entites.View;
using Microsoft.EntityFrameworkCore;

namespace Library.Entites
{
    public class LibraryContex : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Remark> Remarks { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
        public DbSet<TranslatorBooks> TranslatorsBook { get; set; }
        public DbSet<IsbnNumber> IsbnNumbers { get; set; }
        public DbSet<SerieBook> SerieBooks { get; set; }
        public DbSet<AllBooks> ViewAllBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5JJ7LE4\SQLEXPRESS; Database=Library; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IsbnNumber>(isbn =>
            {
                isbn.HasKey(i => i.ISBN);

                isbn.HasOne(b => b.Book)
                .WithOne(i => i.Isbn)
                .HasForeignKey<IsbnNumber>(i => i.BookID);
            });

            modelBuilder.Entity<Book>(book =>
            {
                book.HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity<AuthorBook>(
                    a => a.HasOne(ab => ab.Author)
                    .WithMany()
                    .HasForeignKey(ab => ab.AuthorId),

                    b => b.HasOne(ab => ab.Book)
                    .WithMany()
                    .HasForeignKey(ab => ab.BookId),

                    ab => ab.HasKey(ab => ab.Id)
                    );

                book.HasMany(b => b.Translators)
                .WithMany(t => t.Books)
                .UsingEntity<TranslatorBooks>(
                    t => t.HasOne(tb => tb.Translator)
                    .WithMany()
                    .HasForeignKey(tb => tb.TranslatorId),

                    b => b.HasOne(tb => tb.Book)
                    .WithMany()
                    .HasForeignKey(tb => tb.BookId),
                    
                    tb => tb.HasKey(tb => tb.Id)
                    );

                book.HasMany(b => b.Serie)
                .WithMany(s => s.Books)
                .UsingEntity<SerieBook>(
                    s => s.HasOne(sb => sb.Serie)
                    .WithMany()
                    .HasForeignKey(sb => sb.SerieId),

                    b => b.HasOne(sb => sb.Book)
                    .WithMany()
                    .HasForeignKey(sb => sb.BookId),

                    sb => sb.HasKey(sb => sb.Id)
                    ); 

                book.HasMany(b => b.Remarks)
                .WithOne(r => r.Book)
                .HasForeignKey(r => r.BookID);

                book.HasOne(b => b.Publisher)
                .WithMany(pu => pu.Books)
                .HasForeignKey(b => b.PublisherID);
            });

            modelBuilder.Entity<AllBooks>(view =>
            {
                view.ToView("View_AllBooks");
                view.HasNoKey();
                
                view.Property(view => view.Author).HasColumnName("Autor");
                view.Property(view => view.Translator).HasColumnName("Tłumacz");
                view.Property(view => view.Title).HasColumnName("Tytuł");
                view.Property(view => view.Series).HasColumnName("Seria");
                view.Property(view => view.Publisher).HasColumnName("Wydawnictwo");
                view.Property(view => view.PublishedYear).HasColumnName("Rok wydania");
                view.Property(view => view.HaveRad).HasColumnName("Przeczytane");
            });
        }
    }
}