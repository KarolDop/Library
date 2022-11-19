namespace Library
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

            var publisher = dbContex.Publishers.ToList();
            cobPublisher.DisplayMember = "PublisherName";
            cobPublisher.ValueMember = "Id";
            cobPublisher.DataSource = publisher;

            var series = dbContex.Series.ToList();
            cobSeries.DisplayMember = "SeriesName";
            cobSeries.ValueMember = "Id";
            cobSeries.DataSource = series;

            var authors = dbContex.Authors.ToList();
            cobAuthor.DisplayMember = "FullName";
            cobAuthor.ValueMember = "Id";
            cobAuthor.DataSource = authors;

            var translators = dbContex.Translators.ToList();
            cobTranslator.DisplayMember = "FullName";
            cobTranslator.ValueMember = "Id";
            cobTranslator.DataSource = translators;

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
            var place = "";
            var title = "";
            var publishedYear = 0;
            var isbn = "";
            var comment = "";
            var result = DialogResult.OK;
            var isAdd = true;
            var emptyFieldCheck = new bool[4];
            var emptyFieldString = new string[4];
            var emptyFieldMessage = "";
            var emptyAnyField = false;

            emptyFieldCheck[0] = String.IsNullOrEmpty(txtPlace.Text);
            emptyFieldCheck[1] = String.IsNullOrEmpty(txtTitle.Text);
            emptyFieldCheck[2] = String.IsNullOrEmpty(txtPublishedYear.Text);
            emptyFieldCheck[3] = String.IsNullOrEmpty(mtxtISBN.Text);

            emptyFieldString[0] = "Pole miejsce nie może być puste\n";
            emptyFieldString[1] = "Pole tytuł nie może być puste\n";
            emptyFieldString[2] = "Pole rok nie może być puste\n";
            emptyFieldString[3] = "Pole ISBN nie może być puste\n";

            for (int i = 0; i < 4; i++)
            {
                if (emptyFieldCheck[i])
                {
                    emptyFieldMessage += emptyFieldString[i];
                    emptyAnyField = true;
                }
            }

            if (emptyAnyField)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning(emptyFieldMessage +
                    "Czy Chcesz spróbować raz jeszcze?", "Błąd");
                isAdd = false;
            }
            else
            {
                place = txtPlace.Text;
                title = txtTitle.Text;
                publishedYear = Int32.Parse(txtPublishedYear.Text);
                isbn = mtxtISBN.Text;
                comment = txtComment.Text;
                ;
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
    }
}