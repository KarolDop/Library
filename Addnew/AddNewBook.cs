namespace Library
{
    public partial class frmAddNew : Form
    {
        LibraryContex dbContex;

        public frmAddNew()
        {
            InitializeComponent();
        }

        private void AddNewBook_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();

            var publisher = dbContex.Publishers.ToList();
            cobPublisher.DataSource = publisher;
            cobPublisher.DisplayMember = "PublisherName";

            var series = dbContex.Series.ToList();
            cobSeries.DataSource = series;
            cobSeries.DisplayMember = "SeriesName";

            var authors = dbContex.Authors.ToList();
            cobAuthor.DataSource = authors;
            cobAuthor.DisplayMember = "FullName";

            var translators = dbContex.Translators.ToList();
            cobTranslator.DataSource = translators;
            cobTranslator.DisplayMember = "FullName";

        }

        private void frmAddNewBookClosing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void chbTranslator_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTranslator.Checked == false)
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
            if(chbisbn13.Checked == false)
            {
                mtxtISBN.Mask = "A-AAA-AAAAA-A";
            }
            else
            {
                mtxtISBN.Mask = "AAA-A-AAA-AAAAA-A";
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
            var ISBN = "";
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

            for(int i = 0; i < 4; i++)
            {
                if(emptyFieldCheck[i])
                {
                    emptyFieldMessage += emptyFieldString[i];
                    emptyAnyField = true;
                }
            }

            if(emptyAnyField)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning(emptyFieldMessage +
                    "Czy Chcesz spróbować raz jeszcze?", "Błąd");
                isAdd = false;
            }

        }
    }
}