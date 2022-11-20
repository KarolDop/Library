using Library.AddNewElementForm;
using Library.Entites;
using Library.Entites.View;

namespace Library
{
    public partial class frmLibrary : Form
    {
        LibraryContex dbContex;

        public frmLibrary()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addFormBook = new frmAddNew();
            addFormBook.ShowDialog();
        }

        private void btnAddNewTranslator_Click(object sender, EventArgs e)
        {
            var addFormTranslator = new frmAddNewTranslator();
            addFormTranslator.ShowDialog();
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            var addFormAuthor = new frmAddNewAuthor();
            addFormAuthor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addFormPublisher = new frmAddNewPublisher();
            addFormPublisher.ShowDialog();
        }

        private void btnAddNewSeries_Click(object sender, EventArgs e)
        {
            var addFormSeries = new frmAddNewSeries();
            addFormSeries.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();

            var allBooks = dbContex.ViewAllBooks.ToList();//.OrderBy(allBooks => allBooks.Author);

            dgvAllBooks.DataSource = allBooks;
        }
    }
}