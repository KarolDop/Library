namespace Library
{

    public partial class frmAddNewAuthor : Form
    {
        LibraryContex dbContex;

        public frmAddNewAuthor()
        {
            InitializeComponent();
        }

        public void frmAddNewAuthor_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();
        }

        private void frmAddNewAuthor_closing(object sender, FormClosingEventArgs e)
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
                    var autor = new Author()
                    {
                        AuthorFirstName = firstName,
                        AuthorLastName = lastName,
                        FullName = lastName + ", " + firstName
                    };

                    dbContex.Authors.Add(autor);
                    dbContex.SaveChanges();
                }
                catch (Exception ex)
                {
                    result = CustomMessageBox.YesOrNoMessegeBoxWarning(ex.Message + "Czy chcesz spróbować raz jeszcze?", 
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
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Dodano nowego autora\nCzy chcesz dodać kolejnego?", 
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void goNext(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}