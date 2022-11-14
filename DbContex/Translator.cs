namespace Library
{
    public class Translator
    {
        public int Id { get; set; }
        public string TranslatorFirstName { get; set; }
        public string TranslatorLastName { get; set; }
        public string FullName { get; set; }
        public IList<Book> Books { get; set; }
    }
}