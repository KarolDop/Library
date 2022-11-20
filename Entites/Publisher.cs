namespace Library.Entites
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public IList<Book> Books { get; set; }
    }
}