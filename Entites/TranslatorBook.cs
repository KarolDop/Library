namespace Library.Entites
{
    public class TranslatorBooks
    {
        public int Id { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }

        public Translator Translator { get; set; }
        public int TranslatorId { get; set; }
    }
}