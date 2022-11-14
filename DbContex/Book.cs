namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int PublishYear { get; set; }
        public IList<Author> Authors { get; set; }
        public IList<Translator>? Translators { get; set; }
        //public AuthorBook AuthorBook { get; set; }
        //public int AuthorBookID { get; set; }
        //public TranslatorBook TranslatorBook { get; set; }
        //public int TranslatorBookID { get; set; }

        public Publisher Publisher { get; set; }
        public int PublisherID { get; set; }

        public Place Place { get; set; }
        public int PlaceId { get; set; }

        public Serie Serie { get; set; }
        public int? SeriesID { get; set; }

        public IList<Remark>? Remarks { get; set; }
        public HaveRead HaveReak { get; set; }

        public IsbnNumber Isbn { get; set; }
    }
}