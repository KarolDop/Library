using Library.Entites;
using Library.SupportedClasses;

namespace Library.AddNewElementForm
{
    public partial class frmAddNew : Form
    {
        LibraryContex dbContex;
        HaveRead hr;

        public frmAddNew()
        {
            InitializeComponent();
        }

        private void AddNewBook_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();
            FillComboBoxAddNewBook();

        }

        private void frmAddNewBookClosing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void chbTranslator_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTranslator.Checked == false)
            {
                cobTranslator.Enabled = false;
            }
            else
            {
                cobTranslator.Enabled = true;
            }
        }

        private void chbisbn13_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsbn13.Checked == false)
            {
                mtxtISBN.Mask = "A-AAA-AAAAA-A";
            }
            else
            {
                mtxtISBN.Mask = "AAA-A-AAA-AAAAA-A";
            }
        }

        private void chbHaveRead_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHaveRead.Checked == false)
            {
                hr = HaveRead.No;
            }
            else
            {
                hr = HaveRead.Yes;
            }
        }

        private void chbSeries_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSeries.Checked == false)
            {
                cobSeries.Enabled = false;
            }
            else
            {
                cobSeries.Enabled = true;
            }
        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnSaveNew_Click(object sender, EventArgs e)
        {
            var place = txtPlace.Text;
            var title = txtTitle.Text;
            var isbn = mtxtISBN.Text.Replace(" ", String.Empty);
            var comment = txtComment.Text;
            var result = DialogResult.OK;
            var isAdd = true;
            var emptyFieldCheck = new bool[5];
            var emptyFieldString = new string[5];

            emptyFieldCheck[0] = String.IsNullOrEmpty(place);
            emptyFieldCheck[1] = String.IsNullOrEmpty(title);
            emptyFieldCheck[2] = !Int32.TryParse(txtPublishedYear.Text, out int publishedYear);
            if (chbIsbn13.Checked == false)
            {
                emptyFieldCheck[3] = (isbn.Length != 13);
            }
            else
            {
                emptyFieldCheck[3] = (isbn.Length != 17);
            }
            emptyFieldCheck[4] = DateTime.Now.Year <= publishedYear;
            
            emptyFieldString[0] = "Pole miejsce nie może być puste\n";
            emptyFieldString[1] = "Pole tytuł nie może być puste\n";
            emptyFieldString[2] = "Pole rok nie może być puste\n";
            emptyFieldString[3] = "Pole ISBN nie może być puste\n";
            emptyFieldString[4] = "Rok nie może być późniejszy niż dzisiaj\n";

            var checkEmptyField = EmptyField.EmptyFieldMessage(emptyFieldString, emptyFieldCheck);

            if (checkEmptyField.Item2)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning(checkEmptyField.Item1 +
                    "\nCzy Chcesz spróbować raz jeszcze?", "Błąd");
                isAdd = false;
            }
            else
            {
                Int32.TryParse(cobPublisher.SelectedValue.ToString(), out int publisherID);
                Int32.TryParse(cobSeries.SelectedValue.ToString(), out int seriesID);
                Int32.TryParse(cobAuthor.SelectedValue.ToString(), out int authorID);
                Int32.TryParse(cobTranslator.SelectedValue.ToString(), out int translatorID);

                try
                {
                    var book = new Book()
                    {
                        BookName = title,
                        PublishYear = publishedYear,
                        PublisherID = publisherID,
                        HaveRead = hr,
                        Place = place
                    };
                    dbContex.Books.Add(book);

                    if (!String.IsNullOrEmpty(comment))
                    {
                        var remark = new Remark()
                        {
                            Comment = comment,
                            Book = book,
                        };
                        dbContex.Remarks.Add(remark);
                    }

                    var authorBook = new AuthorBook()
                    {
                        Book = book,
                        AuthorId = authorID,
                    };
                    dbContex.AuthorBook.Add(authorBook);


                    if (chbTranslator.Checked == true)
                    {
                        var translatorBook = new TranslatorBooks()
                        {
                            Book = book,
                            TranslatorId = translatorID,
                        };
                        dbContex.TranslatorsBook.Add(translatorBook);
                    }

                    if (chbSeries.Checked == true)
                    {
                        var serieBook = new SerieBook()
                        {
                            Book = book,
                            SerieId = seriesID
                        };
                        dbContex.SerieBooks.Add(serieBook);
                    }

                    var isbnNo = new IsbnNumber()
                    {
                        ISBN = isbn,
                        Book = book,
                    };
                    dbContex.IsbnNumbers.Add(isbnNo);

                    dbContex.SaveChanges();
                }
                catch (Exception ex)
                {
                    result = CustomMessageBox.YesOrNoMessegeBoxWarning(ex.Message + "\nCzy chcesz spróbować raz jeszcze?",
                        "Bład");
                    isAdd = false;
                }
                finally
                {
                    txtPlace.Clear();
                    txtTitle.Clear();
                    txtPublishedYear.Clear();
                    mtxtISBN.Clear();
                    txtComment.Clear();
                }
            }
            if (isAdd)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Dodano nową książkę\nCzy chcesz dodać kolejną?",
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                cobAuthor.Focus();
            }
        }

        private void goNext(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void acceptInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillComboBoxAddNewBook()
        {
            FillCob<Publisher>.FillDataComboTextBox(cobPublisher, "PublisherName", "Id", dbContex.Publishers.ToList());
            FillCob<Serie>.FillDataComboTextBox(cobSeries, "SeriesName", "Id", dbContex.Series.ToList());
            FillCob<Author>.FillDataComboTextBox(cobAuthor, "FullName", "Id", dbContex.Authors.ToList());
            FillCob<Translator>.FillDataComboTextBox(cobTranslator, "FullName", "Id", dbContex.Translators.ToList());
        }
    }
}