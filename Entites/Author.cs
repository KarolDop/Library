namespace Library.Entites
{

    public class Author
    {
        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string FullName { get; set; }
        public IList<Book> Books { get; set; }
    }
}