using Library.AddNewElementForm;
using Library.Entites;
using Library.DelateElementForm;

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

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w programie \"Moja biblioteczka\"\nWersja: Under construction ", "Witaj!",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var allBooks = dbContex.ViewAllBooks.ToList();

            dgvAllBooks.DataSource = allBooks;
            dgvAllBooks.AutoResizeColumns();
        }

        private void btnDelateSeria_Click(object sender, EventArgs e)
        {
            var deleteFormSeries = new frmDeleteSerie();
            deleteFormSeries.ShowDialog();
        }

        private void btnDeleatePublisher_Click(object sender, EventArgs e)
        {
            var deleteFormPublisher = new frmDeletePublisher();
            deleteFormPublisher.ShowDialog();
        }

        private void btnDelateTranslator_Click(object sender, EventArgs e)
        {
            var deleteFormTranslator = new frmDeleteTranslator();
            deleteFormTranslator.ShowDialog();
        }
    }
}