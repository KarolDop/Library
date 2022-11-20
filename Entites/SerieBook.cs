namespace Library.Entites
{
    public class SerieBook
    {
        public int Id { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }

        public Serie Serie { get; set; }
        public int SerieId { get; set; }
    }
}
