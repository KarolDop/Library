using Library.Entites;
using Library.SupportedClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DelateElementForm
{
    public partial class frmDeletePublisher : Form
    {
        LibraryContex dbContex;

        public frmDeletePublisher()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletePublisher_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();


            FillCob<Publisher>.FillDataComboTextBox(ctxtPublisher, "PublisherName", "Id", dbContex.Publishers.ToList());
        }

        private void DeletePublisher_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32.TryParse(ctxtPublisher.SelectedValue.ToString(), out int publisherToDelete);
            var isDeleted = true;

            var result = DialogResult.OK;
            try
            {
                var publisher = dbContex.Publishers.Where(s => s.Id == publisherToDelete).ToList();

                var bookToDelete = new List<Book>();

                foreach (var book in dbContex.Books)
                {
                    if (book.PublisherID == publisherToDelete)
                    {
                        bookToDelete.Add(book);
                        idBookToDelete.Add(book.Id);
                    }
                }

                dbContex.Publishers.RemoveRange(publisher);
                if (bookToDelete.Count != 0)
                    dbContex.Books.RemoveRange(bookToDelete);
                dbContex.SaveChanges();
            }
            catch (Exception ex)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning("Nie udało się usunać wyniku czy chesz spróbować raz jeszcze?", "Błąd");
                isDeleted = false;
            }

            if (isDeleted)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Usunięto wydawnictwo\nCzy chcesz usunąć kolejną?",
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                FillCob<Publisher>.FillDataComboTextBox(ctxtPublisher, "PublisherName", "Id", dbContex.Publishers.ToList());
            }
        }
    }
}
