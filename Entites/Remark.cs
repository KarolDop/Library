namespace Library.Entites
{
    public class Remark
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public Book Book { get; set; }
        public int BookID { get; set; }
    }
}