﻿using Library.Entites;
using Library.SupportedClasses;
using System.Data;

namespace Library.DelateElementForm
{
    public partial class frmDeleteTranslator : Form
    {
        LibraryContex dbContex;

        public frmDeleteTranslator()
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

            FillCob<Translator>.FillDataComboTextBox(ctxtTranslator, "FullName", "Id", dbContex.Translators.ToList());

            var result = DialogResult.OK;

            try
            {
                DialogResult allOrNot = CustomMessageBox.YesOrNoMessegeBoxInformation("Czy chcesz usunąć również rekordy książek gdzie jest więcej niż jeden tłuymacz?","Pytanie");

                switch(allOrNot)
                {
                    case DialogResult.Yes:
                        {
                            goto default;
                        }
                    case DialogResult.No:
                        {
                            goto default;
                        }
                    default:
                        CustomMessageBox.YesOrNoMessegeBoxInformation("Usunięto tłumacza\nCzy chcesz usunąć kolejnego?", "Sukces!");
                        break;
                }
            }
            catch (Exception ex)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning("Nie udało się usunać wyniku czy chesz spróbować raz jeszcze?", "Błąd");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                FillCob<Translator>.FillDataComboTextBox(ctxtTranslator, "FullName", "Id", dbContex.Translators.ToList());
            }
        }

        private void DeleteSeries_closing(object sender, FormClosingEventArgs e)
        {
            dbContex.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32.TryParse(ctxtTranslator.SelectedValue.ToString(), out int idTranslatorToDelete);

            var result = DialogResult.OK;

            try
            {
                DialogResult allOrNot = CustomMessageBox.YesOrNoMessegeBoxInformation("Czy chcesz usunąć również rekordy książek gdzie jest więcej niż jeden tłumacz?", "Pytanie");

                switch (allOrNot)
                {
                    case DialogResult.Yes:
                        {
                            goto default;
                        }
                    case DialogResult.No:
                        {
                            var translator = dbContex.Translators.Where(t => t.Id == idTranslatorToDelete).ToList();
                            dbContex.Translators.RemoveRange(translator);
                            dbContex.SaveChanges();
                            goto default;
                        }
                    default:
                        CustomMessageBox.YesOrNoMessegeBoxInformation("Usunięto tłumacza\nCzy chcesz usunąć kolejnego?", "Sukces!");
                        break;
                }
            }
            catch (Exception ex)
            {
                result = CustomMessageBox.YesOrNoMessegeBoxWarning("Nie udało się usunać wyniku czy chesz spróbować raz jeszcze?", "Błąd");
            }

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                FillCob<Translator>.FillDataComboTextBox(ctxtTranslator, "FullName", "Id", dbContex.Translators.ToList());
            }
        }
    }
}
