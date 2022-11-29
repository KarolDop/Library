using Library.Entites;
using System.Data;
using Library.SupportedClasses;


namespace Library.DelateElementForm
{
    public partial class frmDeleteSerie : Form
    {
        LibraryContex dbContex;

        public frmDeleteSerie()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32.TryParse(ctxtSeries.SelectedValue.ToString(), out int seriesToDelete);

            DialogResult allOrNot = CustomMessageBox.YesOrNoMessegeBoxInformation("Czy chcesz usunać wszystkie powiązane dane?", "Pytanie");

            if (allOrNot == DialogResult.No)
            {
                var series = dbContex.Series.Where(sb => sb.Id == seriesToDelete).ToList();
                dbContex.Series.RemoveRange(series);
                dbContex.SaveChanges();
            }
            else
            {
                var series = dbContex.Series.Where(s => s.Id == seriesToDelete).ToList();
                var seriesBook = dbContex.SerieBooks.Where(sb => sb.SerieId == seriesToDelete).ToList();
                IQueryable<Book> book = null;
                List<Book> bookList = new List<Book>();
                foreach (var item in seriesBook)
                {
                    if (seriesBook.First() == item)
                    {
                        book = (dbContex.Books.Where(b => b.Id == item.BookId));
                    }
                    else
                    {
                        book = book.Concat(dbContex.Books.Where(b => b.Id == item.BookId));
                    }
                }
                bookList = book.ToList();

                dbContex.Series.RemoveRange(series);
                dbContex.SerieBooks.RemoveRange(seriesBook);
                dbContex.Books.RemoveRange(bookList);

                dbContex.SaveChanges();
            }
        }

        private void DeleteSeries_load(object sender, EventArgs e)
        {           
            dbContex = new LibraryContex();

            var series = dbContex.Series.ToList();
            ctxtSeries.DisplayMember = "SeriesName";
            ctxtSeries.ValueMember = "Id";
            ctxtSeries.DataSource = series;
        }

        private void DeleteSeries_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }
    }
}
