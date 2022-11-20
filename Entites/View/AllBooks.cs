namespace Library.Entites.View
{
    public class AllBooks
    {
        public string Author { get; set; }
        public string? Translator { get; set; }
        public string Title { get; set; }
        public string? Series { get; set; }
        public string Publisher { get; set; }
        public int PublishedYear { get; set; }
        public  HaveRead HaveRad { get; set; }
    }
}
