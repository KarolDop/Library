namespace Library
{
    public class TranslatorBook
    {
        public int Id { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }

        public Translator Translator { get; set; }
        public int TranslatorId { get; set; }
    }
}