namespace Library
{
    public partial class frmLibrary : Form
    {
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
    }
}