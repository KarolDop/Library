﻿namespace Library.Entites
{
    public class AuthorBook
    {
        public int Id { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}