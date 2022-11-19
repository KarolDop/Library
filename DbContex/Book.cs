namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int PublishYear { get; set; }
        public IList<Author> Authors { get; set; }
        public IList<Translator>? Translators { get; set; }

        public Publisher Publisher { get; set; }
        public int PublisherID { get; set; }

        public string Place { get; set; }

        public IList<Serie>? Serie { get; set; }
        //public int? SeriesID { get; set; }

        public IList<Remark>? Remarks { get; set; }
        public HaveRead HaveRead { get; set; }

        public IsbnNumber Isbn { get; set; }
    }
}