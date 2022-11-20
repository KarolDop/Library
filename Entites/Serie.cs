namespace Library.Entites
{
    public class Serie
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public IList<Book> Books { get; set; }
    }
}