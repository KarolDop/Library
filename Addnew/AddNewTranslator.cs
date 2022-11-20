using Library.SupportedClasses;

namespace Library
{
    public partial class frmAddNewTranslator : Form
    {
        LibraryContex dbContex;

        public frmAddNewTranslator()
        {
            InitializeComponent();
        }

        private void frmAddNewTranslator_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();
        }

        private void frmAddNewTranslator_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var firstName = "";
            var lastName = "";
            var result = DialogResult.OK;
            var isAdd = true;

            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text))
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning("Nie można zapisać pustego pola do bazy danych\n" +
                    "Czy Chcesz spróbować raz jeszcze?", "Błąd");
                isAdd = false;
            }
            else
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;

                try
                {

                    var translator = new Translator()
                    {
                        TranslatorFirstName = firstName,
                        TranslatorLastName = lastName,
                        FullName = lastName + ", " + firstName
                    };

                    dbContex.Translators.Add(translator);
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
                    txtFirstName.Clear();
                    txtLastName.Clear();
                }
            }

            if (isAdd)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Dodano nowego tłumacza\nCzy chcesz dodać kolejnego?",
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                txtFirstName.Focus();
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
