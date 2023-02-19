using Library.Entites;
using Library.SupportedClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DelateElementForm
{
    public partial class DeleteTranslator : Form
    {
        LibraryContex dbContex;

        public DeleteTranslator()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteSeries_load(object sender, EventArgs e)
        {
            dbContex = new LibraryContex();


            FillCob<Serie>.FillDataComboTextBox(ctxtTranslator, "SeriesName", "Id", dbContex.Series.ToList());
        }

        private void DeleteSeries_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
