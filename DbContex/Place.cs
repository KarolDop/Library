namespace Library
{
    public class Place
    {
        public int Id { get; set; }
        public string PublicationPlace { get; set; }
        public IList<Book> Books { get; set; }
    }
}