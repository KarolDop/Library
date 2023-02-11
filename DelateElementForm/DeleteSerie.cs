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
            var isDeleted = true;

            var result = DialogResult.OK;


            try
            {
                DialogResult allOrNot = CustomMessageBox.YesOrNoMessegeBoxInformation("Czy chcesz usunać wszystkie powiązane dane?", "Pytanie");

                if (allOrNot == DialogResult.No)
                {
                    var series = dbContex.Series.Where(s => s.Id == seriesToDelete).ToList();
                    dbContex.Series.RemoveRange(series);
                    dbContex.SaveChanges();
                }
                else
                {
                    var series = dbContex.Series.Where(s => s.Id == seriesToDelete).ToList();

                    var seriesBook = dbContex.SerieBooks.Where(sb => sb.SerieId == seriesToDelete).ToList();

                    IQueryable<Book> bookContex = null;

                    if (seriesBook.Count != 0)
                    {
                        foreach (var item in seriesBook)
                        {
                            if (seriesBook.First() == item)
                            {
                                bookContex = dbContex.Books.Where(b => b.Id == item.BookId);
                            }
                            else
                            {
                                bookContex = bookContex.Concat(dbContex.Books.Where(b => b.Id == item.BookId));
                            }
                        }
                    }
                    List<Book> books = new List<Book>(bookContex.ToList()); 

                    dbContex.Series.RemoveRange(series);
                    if(seriesBook.Count != 0)
                        dbContex.SerieBooks.RemoveRange(seriesBook);
                    if(books.Count != 0)
                        dbContex.Books.RemoveRange(books);

                    dbContex.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning("Nie udało się usunać wyniku czy chesz spróbować raz jeszcze?", "Błąd");
                isDeleted = false;
            }

            if (isDeleted)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Usunięto serię\nCzy chcesz usunąć kolejną?",
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                FillCob<Serie>.FillDataComboTextBox(ctxtSeries, "SeriesName", "Id", dbContex.Series.ToList());
            }
        }

        private void DeleteSeries_load(object sender, EventArgs e)
        {           
            dbContex = new LibraryContex();


            FillCob<Serie>.FillDataComboTextBox(ctxtSeries, "SeriesName", "Id", dbContex.Series.ToList());
        }

        private void DeleteSeries_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }
    }
}