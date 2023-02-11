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
            Int32.TryParse(ctxtSeries.SelectedValue.ToString(), out int idSeriesToDelete);
            var isDeleted = true;

            var result = DialogResult.OK;


            try
            {
                DialogResult allOrNot = CustomMessageBox.YesOrNoMessegeBoxInformation("Czy chcesz usunać wszystkie powiązane dane?", "Pytanie");

                if (allOrNot == DialogResult.No)
                {
                    var seriesToDelete = dbContex.Series.Where(s => s.Id == idSeriesToDelete).ToList();
                    dbContex.Series.RemoveRange(seriesToDelete);
                    dbContex.SaveChanges();
                }
                else
                {
                    var seriesToDelete = dbContex.Series.Where(s => s.Id == idSeriesToDelete).ToList();

                    var seriesBookToDelete = dbContex.SerieBooks.Where(sb => sb.SerieId == idSeriesToDelete).ToList();

                    var bookToDelete = new List<Book>();

                    foreach (var item in seriesBookToDelete)
                    {
                        foreach (var item2 in dbContex.Books)
                        {
                            if (item2.Id == item.Id)
                                bookToDelete.Add(item2);
                        }
                    }

                    dbContex.Series.RemoveRange(seriesToDelete);
                    if(seriesBookToDelete.Count != 0)
                        dbContex.SerieBooks.RemoveRange(seriesBookToDelete);
                    if(bookToDelete.Count != 0)
                        dbContex.Books.RemoveRange(bookToDelete);

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