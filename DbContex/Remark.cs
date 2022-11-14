//using System.Data.Entity;

namespace Library
{
    public class Remark
    {
        public int Id { get; set; }
        public string Remarks { get; set; }

        public Book Book { get; set; }
        public int BookID { get; set; }
    }
}