using Library.Entites;
using Library.SupportedClasses;

namespace Library.AddNewElementForm
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
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var result = DialogResult.OK;
            var isAdd = true;
            var emptyFieldCheck = new bool[2];
            var emptyFieldString = new string[2];

            emptyFieldCheck[0] = String.IsNullOrEmpty(firstName);
            emptyFieldCheck[1] = String.IsNullOrEmpty(lastName);

            emptyFieldString[0] = "Pole imię nie może być puste\n";
            emptyFieldString[1] = "Pole naziwsko nie może być puste\n";

            var checkEmptyField = EmptyField.EmptyFieldMessage(emptyFieldString, emptyFieldCheck);

            if (checkEmptyField.Item2)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning(checkEmptyField.Item1 +
                    "\nCzy Chcesz spróbować raz jeszcze?", "Błąd");
                isAdd = false;
            }
            else
            {
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
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Dodano nowego autora\nCzy chcesz dodać kolejnego?", 
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
            if(e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}