namespace Library
{
    public class Remarks
    {
        public int Id { get; set; }
        public string Remark { get; set; }

        public Book Book { get; set; }
        public int BookID { get; set; }
    }
}