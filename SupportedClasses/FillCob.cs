using Library.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.SupportedClasses
{
    public class FillCob
    {
        public static void FillDataComboTextBox(ComboBox box ,string display, string value, LibraryContex dbContex)
        {
            var data = dbContex.Series.ToList();
            box.DisplayMember = display;
            box.ValueMember = value;
            box.DataSource = data;
        }
    }
}
