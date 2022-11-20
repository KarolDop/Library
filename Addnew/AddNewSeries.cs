using Library.SupportedClasses;

namespace Library
{
    public partial class frmAddNewSeries : Form
    {
        LibraryContex dbContex;

        public frmAddNewSeries()
        {
            InitializeComponent();
        }

        private void frmAddNewSeries_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();
        }

        private void frmAddNewSeries_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var seriesName = txtSeriesName.Text;
            var result = DialogResult.OK;
            var isAdd = true;
            var emptyFieldCheck = new bool[1];
            var emptyFieldString = new string[1];

            emptyFieldCheck[0] = String.IsNullOrEmpty(seriesName);

            emptyFieldString[0] = "Pole seria nie może być puste\n";

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
                    var seria = new Serie()
                    {
                        SeriesName = seriesName
                    };

                    dbContex.Series.Add(seria);
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
                    txtSeriesName.Clear();
                }
            }

            if (isAdd)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxInformation("Dodano nową serie\nCzy chcesz dodać kolejnego?",
                    "Sukces!");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                txtSeriesName.Focus();
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